using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
using SamurailApp.Data;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
namespace SamuraiApp.UI
{
    class Program
    {
        private static SamuraiContext _context = new SamuraiContext();
        static void Main(string[] args)
        {
            //_context.Database.EnsureCreated();
            //GetSamurais("Before Add :");
            //AddSamurai();
            //GetSamurais("After Add :");
            //Console.WriteLine("Press any key ");
            //AddSamuraisByName("Shimada", "Okamoto", "Kikuchio", "Hayashida");
            // AddVariousTypes();
            //AddQuoteToExistingSamuraiWhileTracking();
            Console.ReadKey();
            
        }
        
        //One To One RelationShip
        private static void GetSamuraiWithHorses()
        {
            var samurais = _context.Samurais.Include(s => s.Horse).ToList();

        }
        private static void ReplaceAHorese()
        {
            var samurai = _context.Samurais.Include(s => s.Horse)
                .FirstOrDefault(s => s.ID == 5);
            samurai.Horse = new Horse { Name = "Tigger" };
            _context.SaveChanges();
        }
        private static void AddNewHorseToSamuraiusingId()
        {
            var horse = new Horse { Name = "Scout", SamuraiId = 2 };
            _context.Horses.Add(horse);
            _context.SaveChanges();

        }
        private static void AddNewHorseToSamuraiObject()
        {
            var samurai = _context.Samurais.Find(12);
            samurai.Horse = new Horse { Name = "Black Beauty" };
            _context.SaveChanges();

        }


        // Many To Many RelationShip
        private static void PrePopulateSamuraisAndBattles()
        {
            _context.AddRange(
             new Samurai { Name = "Kikuchiyo" },
             new Samurai { Name = "Kambei Shimada" },
             new Samurai { Name = "Shichirōji " },
             new Samurai { Name = "Katsushirō Okamoto" },
             new Samurai { Name = "Heihachi Hayashida" },
             new Samurai { Name = "Kyūzō" },
             new Samurai { Name = "Gorōbei Katayama" }
           );

            _context.Battles.AddRange(
             new Battle { Name = "Battle of Okehazama", StartDate = new DateTime(1560, 05, 01), EndDate = new DateTime(1560, 06, 15) },
             new Battle { Name = "Battle of Shiroyama", StartDate = new DateTime(1877, 9, 24), EndDate = new DateTime(1877, 9, 24) },
             new Battle { Name = "Siege of Osaka", StartDate = new DateTime(1614, 1, 1), EndDate = new DateTime(1615, 12, 31) },
             new Battle { Name = "Boshin War", StartDate = new DateTime(1868, 1, 1), EndDate = new DateTime(1869, 1, 1) }
           );
            _context.SaveChanges();
        }
        private static void JoinBattleAndSamurai()
        {
            //Kikuchiyo id is 1, Siege of Osaka id is 3
            var sbJoin = new BattleSamurai { SamuraiId = 1, BattleId = 3 };
            _context.Add(sbJoin);
            _context.SaveChanges();
        }
        private static void EnlistSamuraiIntoABattle()
        {
            var battle = _context.Battles.Find(1);
            battle.BattleSamurai
                .Add(new BattleSamurai { SamuraiId = 3 });
            _context.SaveChanges();
        }

        private static void RemoveBattleFromSamuraiWhenDisconnected()
        {
            //Goal:Remove join between Shichirōji(Id=3) and Battle of Okehazama (Id=1)
            Samurai samurai;
            using (var separateOperation = new SamuraiContext())
            {
                samurai = separateOperation.Samurais.Include(s => s.BattleSamurai)
                                                    .ThenInclude(sb => sb.Battle)
                                           .SingleOrDefault(s => s.Id == 3);
            }
            var sbToRemove = samurai.BattleSamurai.SingleOrDefault(sb => sb.BattleId == 1);
            samurai.BattleSamurai.Remove(sbToRemove);
            //_context.Attach(samurai);
            //_context.ChangeTracker.DetectChanges();
            _context.Remove(sbToRemove);
            _context.SaveChanges();
        }
        private static void RemoveBattleFromSamurai()
        {
            //Goal:Remove join between Shichirōji(Id=3) and Battle of Okehazama (Id=1)
            var samurai = _context.Samurais.Include(s => s.BattleSamurai)
                                           .ThenInclude(sb => sb.Battle)
                                  .SingleOrDefault(s => s.Id == 3);
            var sbToRemove = samurai.SamuraiBattles.SingleOrDefault(sb => sb.BattleId == 1);
            samurai.SamuraiBattles.Remove(sbToRemove); //remove via List<T>
                                                       //_context.Remove(sbToRemove); //remove using DbContext
            _context.ChangeTracker.DetectChanges(); //here for debugging
            _context.SaveChanges();
        }
        private static void RemoveJoinBetweenSamuraiAndBattleSimple()
        {
            var join = new BattleSamurai { BattleId = 1, SamuraiId = 8 };
            _context.Remove(join);
            _context.SaveChanges();
        }
        private static void GetBattlesForSamuraiInMemory()
        {
            var battle = _context.Battles.Find(1);
            _context.Entry(battle).Collection(b => b.BattleSamurai).Query().Include(sb => sb.Samurai).Load();

        }
        private static void GetSamuraiWithBattles()
        {
            var samuraiWithBattles = _context.Samurais
                .Include(s => s.BattleSamurai)
                .ThenInclude(sb => sb.Battle).FirstOrDefault(s => s.Id == 1);
            var battle = samuraiWithBattles.SamuraiBattles.First().Battle;
            var allTheBattles = new List<Battle>();
            foreach (var samuraiBattle in samuraiWithBattles.SamuraiBattles)
            {
                allTheBattles.Add(samuraiBattle.Battle);
            }
        }
        private static void AddNewSamuraiViaDisconnectedBattleObject()
        {
            Battle battle;
            using (var separateOperation = new SamuraiContext())
            {
                battle = separateOperation.Battles.Find(1);
            }
            var newSamurai = new Samurai { Name = "SampsonSan" };
            battle.BattleSamurai.Add(new BattleSamurai { Samurai = newSamurai });
            _context.Battles.Attach(battle);
            _context.ChangeTracker.DetectChanges();
            _context.SaveChanges();
        }

        private static void EnlistSamuraiIntoABattleUntracked()
        {
            Battle battle;
            using (var separateOperation = new SamuraiContext())
            {
                battle = separateOperation.Battles.Find(1);
            }
            battle.BattleSamurai.Add(new BattleSamurai { SamuraiId = 2 });
            _context.Battles.Attach(battle);
            _context.ChangeTracker.DetectChanges(); //here to show you debugging info
            _context.SaveChanges();

        }

        //private static void RemoveSamuraisFromBattleExplicit()
        //{
        //    var b_s = _context.Set<BattleSamurai>()
        //        .SingleOrDefault(bs => bs.BattleId == 1 && bs.SamuraiId == 10);
        //    if(b_s!=null)
        //    {
        //        _context.Set<BattleSamurai>().Remove(b_s);
        //        _context.SaveChanges();
        //    }
        //}
        //private static void RemoveSamuraisFromBattle()
        //{
        //    var battlewithsamurai = _context.Battles
        //        .Include(b => b.BattleSamurai.Where(s => s.Samurai.ID== 12))
        //        .Single(s => s.BattleId == 1);
        //    var samurai = battlewithsamurai.BattleSamurai[0];
        //    battlewithsamurai.BattleSamurai.Remove(samurai);
        //    _context.SaveChanges();


        //}
        //private static void AddAllSamuraisToAllBattles()
        //{
        //    var allSamurais = _context.Samurais.ToList();
        //    var allBattles = _context.Battles.Include(b=>b.BattleSamurai).ToList();
        //    foreach (var battle in allBattles)
        //    {
        //        battle.Samurais.AddRange(allSamurais);
        //    }
        //    _context.SaveChanges();
        //}
        //private static void ReturnAllBattleWithSamurais()
        //{
        //    var battle = _context.Battles.Include(b => b.Samurais).ToList();

        //}
        //private static void ReturnBattleWithSamurais()
        //{
        //    var battle = _context.Battles.Include(b => b.Samurais).FirstOrDefault();

        //}
        //private static void AddingNewSamuraiToAnExsitingBattle()
        //{
        //    var battle = _context.Battles.FirstOrDefault();
        //    battle.Samurais.Add(new Samurai { Name = "Aly Ahmed" });
        //    _context.SaveChanges();
        //}
        //private static void ModyfingRelatedDataWhenTracked()
        //{
        //    var samurai = _context.Samurais.Include(s => s.Quotes)
        //        .FirstOrDefault(s => s.ID ==2);
        //    samurai.Quotes[0].Text = "Did You hear me !!";
        //    _context.SaveChanges();
        //}

        // One To Many RelationShip 
        private static void ProjectionSmauraiwithQuotes()
        {
            //var somePropwithQuotes = _context.Samurais.
            //    Select(s => new { s.ID, s.Name, QuotesCount = s.Quotes.Count }).ToList();

            var somePropwithQuotes = _context.Samurais.
                Select(s => new
                {
                    s.ID,
                    s.Name,
                    HappyQuotes = s.Quotes.Where(q => q.Text.Contains("happy"))
                }).ToList();
        }
        private static void ProjectionSomeProperties()
        {
            var someProperites = _context.Samurais.Select(s => new { s.ID, s.Name }).ToList();

        }
        private static void EagerLoadSamuraiwithQuotes()
        {
            //var samuraiwithQuotes = _context.Samurais.Include(s => s.Quotes).ToList();
            var filterInclude = _context.Samurais.
                Include(s => s.Quotes.Where(q => q.Text.Contains("thanks"))).ToList();

            var filterPrimaryEntityWithInclude = _context.Samurais
                .Where(s => s.Name.Contains("mahmoud")).Include(s => s.Quotes).FirstOrDefault();

            var filterPrimaryEntityWith2Include = _context.Samurais
                .Where(s => s.Name.Contains("Aly")).Include(s => s.Quotes).Include(s => s.BattleSamurai).ToList();
        }
        private static void AddQuoteToExistingSamuraiWhileTracking()
        {
            var samurai = _context.Samurais.FirstOrDefault();
            samurai.Quotes.Add(new Quote { Text = "I bet you are happy !" });
            _context.SaveChanges(); 
        }
        private static void InsertNewSamiraiWithQuote()
        {
            var samurai = new Samurai
            {
                Name="Kambei Samurai",
                Quotes=new List<Quote>
                {
                    new Quote{Text="I've come to save you !!!"},
                     new Quote{Text="I've come to save you Again !!!"}
                }
            };
            _context.Samurais.Add(samurai);
            _context.SaveChanges();
        }

        // Some Query  Operations 
        private static void RetrieveAndDeleteASamurai()
        {
            var samurai = _context.Samurais.Find(18);
            _context.Samurais.Remove(samurai);
            _context.SaveChanges();
        }
        private static void MultipleDatabaseOperations()
        {
            var samurai = _context.Samurais.FirstOrDefault();
            samurai.Name += "San";
            _context.Samurais.Add(new Samurai { Name = "Shino" });
            _context.SaveChanges();
        }
        private static void RetrieveAndUpdateMultipleSamurais()
        {
            var samurais = _context.Samurais.Skip(1).Take(4).ToList();
            samurais.ForEach(s => s.Name += "San");
            _context.SaveChanges();
        }
        private static void RetrieveAndUpdateSamurai()
        {
            var samurai = _context.Samurais.FirstOrDefault();
            samurai.Name += "San";
            _context.SaveChanges();
        }
        private static void QueryAggregates()
        {
            //var name = "Sampson";
            //var samurai = _context.Samurais.FirstOrDefault(s => s.Name == name);
            var samurai = _context.Samurais.Find(2);
        }
        private static void QueryFilters()
        {
            //var name = "Sampson";
            //var samurais = _context.Samurais.Where(s => s.Name == name).ToList();
            var filter = "J%";
            
            var samurais = _context.Samurais
                .Where(s => EF.Functions.Like(s.Name, filter)).ToList();
        }
        private static void AddVariousTypes()
        {
            _context.AddRange(new Samurai { Name = "Shimada" },
                              new Samurai { Name = "Okamoto" },
                              new Battle { Name = "Battle of Anegawa" },
                              new Battle { Name = "Battle of Nagashino" });
            //_context.Samurais.AddRange(
            //    new Samurai { Name = "Shimada" },
            //    new Samurai { Name = "Okamoto" });
            //_context.Battles.AddRange(
            //    new Battle { Name = "Battle of Anegawa" },
            //    new Battle { Name = "Battle of Nagashino" });
            _context.SaveChanges();
        }
        private static void AddSamuraisByName(params string[] names)
        {
            foreach (string name in names)
            {
                _context.Samurais.Add(new Samurai { Name = name });
            }
            _context.SaveChanges();
        }
        public static void AddSamurai()
        {
            var Samurai = new Samurai { Name = "Sampson" };
            _context.Samurais.Add(Samurai);
            _context.SaveChanges();
        }
        public static void GetSamurais(string text)
        {
            var samurais = _context.Samurais.ToList();
            Console.WriteLine($"{text}: Samurai count is : {samurais.Count}");
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }

        //Quering The DataBase Views 
        public static void  QuerySamuraiBattleStats()
        {
            var stats = _context.SamuraiBattleStat.ToList();
            var firstStat = _context.SamuraiBattleStat.FirstOrDefault();
            var sampsonState = _context.SamuraiBattleStat
                .FirstOrDefault(b => b.Name == "SamSonSan");
        }
        //Querying using RowSql
        public static void QueryUsingRawSql()
        {
            var samurai = _context.Samurais.FromSqlRaw("select * from samurais").ToList();
            var samuraiWithQuotes = _context.Samurais.FromSqlRaw("select Id,Name from samurais  ")
                .Include(s => s.Quotes).ToList();
            string name = "mahmoud";
            var specificSamurai = _context.Samurais
                .FromSqlInterpolated($"select * from samurais where Name={name}").ToList();


        }
        // Running and Quering  Stored Procedure
        public static void  QueringUsingFromSqlRawStroredProc()
        {
            var text = "Happy";
            var samurai = _context.Samurais.FromSqlRaw(
                "EXEC adb.SamuraisWhoSaidAWord {0}", text).ToList();
        }
        //Executing Non-Query Raw SQL Commonds
        public static void ExecuteSomRowSql()
        {
            var samuraiId = 2;
            _context.Database
                .ExecuteSqlRaw("EXEC DeleteQuotesForSamurai {0}",samuraiId);
        }

    }
}
