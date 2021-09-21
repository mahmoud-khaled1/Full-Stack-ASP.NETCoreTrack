using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamuraiApp.Domain;
using Microsoft.Extensions.Logging;

namespace SamurailApp.Data
{
    public class SamuraiContext:DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<BattleSamurai> BattleSamurais { get; set; }
        public DbSet<SamuraiBattleStat> SamuraiBattleStat { get; set; }
        public DbSet<Horse> Horses { get; set; }

        public SamuraiContext()
        {
                
        }
        public SamuraiContext(DbContextOptions opt):base(opt)
        {
                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=  (localdb)\\MSSQLLocalDB;Initial Catalog=SamuraiAppData");
                //.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name//,
                //                                 //DbLoggerCategory.Database.Transaction.Name
                //                               },
                //       LogLevel.Information)
                //.EnableSensitiveDataLogging();
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samurai>()
                .HasMany(s => s.Battles)
                .WithMany(b => b.Samurais)
                .UsingEntity<BattleSamurai>
                (bs => bs.HasOne<Battle>().WithMany(),
                bs => bs.HasOne<Samurai>().WithMany())
                .Property(bs => bs.DateJoined)
                .HasDefaultValueSql("getdate()");

            // For SamuraiBattleStats View 
            modelBuilder.Entity<SamuraiBattleStat>().HasNoKey().ToView("SamuraiBattleStats");
        }

    }
}
