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
        private static void RemoveSamuraisFromBattleExplicit()
        {
            var b_s = _context.Set<BattleSamurai>()
                .SingleOrDefault(bs => bs.BattleId == 1 && bs.SamuraiId == 10);
            if(b_s!=null)
            {
                _context.Set<BattleSamurai>().Remove(b_s);
                _context.SaveChanges();
            }
        }
        private static void RemoveSamuraisFromBattle()
        {
            var battlewithsamurai = _context.Battles
                .Include(b => b.Samurais.Where(s => s.ID == 12))
                .Single(s => s.BattleId == 1);
            var samurai = battlewithsamurai.Samurais[0];
            battlewithsamurai.Samurais.Remove(samurai);
            _context.SaveChanges();


        }
        private static void AddAllSamuraisToAllBattles()
        {
            var allSamurais = _context.Samurais.ToList();
            var allBattles = _context.Battles.Include(b=>b.Samurais).ToList();
            foreach (var battle in allBattles)
            {
                battle.Samurais.AddRange(allSamurais);
            }
            _context.SaveChanges();
        }
        private static void ReturnAllBattleWithSamurais()
        {
            var battle = _context.Battles.Include(b => b.Samurais).ToList();

        }
        private static void ReturnBattleWithSamurais()
        {
            var battle = _context.Battles.Include(b => b.Samurais).FirstOrDefault();

        }
        private static void AddingNewSamuraiToAnExsitingBattle()
        {
            var battle = _context.Battles.FirstOrDefault();
            battle.Samurais.Add(new Samurai { Name = "Aly Ahmed" });
            _context.SaveChanges();
        }
        private static void ModyfingRelatedDataWhenTracked()
        {
            var samurai = _context.Samurais.Include(s => s.Quotes)
                .FirstOrDefault(s => s.ID ==2);
            samurai.Quotes[0].Text = "Did You hear me !!";
            _context.SaveChanges();
        }

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
                .Where(s => s.Name.Contains("Aly")).Include(s => s.Quotes).Include(s => s.Battles).ToList();
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
