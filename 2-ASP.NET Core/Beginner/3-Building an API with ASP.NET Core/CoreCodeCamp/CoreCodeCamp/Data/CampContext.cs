using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
namespace CoreCodeCamp
{
    public class CampContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public CampContext(DbContextOptions<CampContext> options) : base(options)
        {
                
        }
        public Microsoft.EntityFrameworkCore.DbSet<Camp> Camps { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Speaker> Speakers { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Talk> Talks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Camp>(c =>
            {
                //seed Camp
                c.HasData(new
                {
                    CampId = 1,
                    Moniker = "ATL2018",
                    Name = "Atlanta Code Camp",
                    EventDate = new DateTime(2018, 10, 18),
                    Length = 1
                    
                    
                });

                //Seed Location
                c.OwnsOne(c => c.Location).HasData(new
                {
                    CampId = 1,
                    LocationId = 1,
                    VenueName = "Atlanta Convention Center",
                    Address1 = "123 Main Street",
                    CityTown = "Atlanta",
                    StateProvince = "GA",
                    PostalCode = "12345",
                    Country = "USA"
                });

                
                //Seed Talks
                c.OwnsOne(c => c.Talks).HasData(new {
                    CampId = 1,
                    TalkId = 1,
                        Title = "Entity Framework From Scratch",
                        Abstract = "Entity Framework from scratch in an hour. Probably cover it all",
                        Level = 100,
                        Speaker = new Speaker
                        {
                            
                            SpeakerId = 1,
                            FirstName = "Shawn",
                            LastName = "Wildermuth",
                            BlogUrl = "http://wildermuth.com",
                            Company = "Wilder Minds LLC",
                            CompanyUrl = "http://wilderminds.com",
                            GitHub = "shawnwildermuth",
                            Twitter = "shawnwildermuth"
                        }
                });
            });


































            //// see Talk
            //Talk[] talkk = new Talk[] 
            //{new Talk
            //        {
            //          TalkId = 1,
            //          Title = "Entity Framework From Scratch",
            //          Abstract = "Entity Framework from scratch in an hour. Probably cover it all",
            //          Level = 100,
            //          Speaker = new Speaker
            //          {
            //            SpeakerId = 1,
            //            FirstName = "Shawn",
            //            LastName = "Wildermuth",
            //            BlogUrl = "http://wildermuth.com",
            //            Company = "Wilder Minds LLC",
            //            CompanyUrl = "http://wilderminds.com",
            //            GitHub = "shawnwildermuth",
            //            Twitter = "shawnwildermuth"
            //          }
            //        },
            //        new Talk
            //        {
            //          TalkId = 2,
            //          Title = "Writing Sample Data Made Easy",
            //          Abstract = "Thinking of good sample data examples is tiring.",
            //          Level = 200,
            //          Speaker = new Speaker
            //          {
            //            SpeakerId = 2,
            //            FirstName = "Resa",
            //            LastName = "Wildermuth",
            //            BlogUrl = "http://shawnandresa.com",
            //            Company = "Wilder Minds LLC",
            //            CompanyUrl = "http://wilderminds.com",
            //            GitHub = "resawildermuth",
            //            Twitter = "resawildermuth"
            //          }
            //        }
            //};

            ////Seed Location 

            //Location Lo = new Location()
            //{
            //    LocationId = 1,
            //    VenueName = "Atlanta Convention Center",
            //    Address1 = "123 Main Street",
            //    CityTown = "Atlanta",
            //    StateProvince = "GA",
            //    PostalCode = "12345",
            //    Country = "USA"
            //};

            ////seed Camp
            //modelBuilder.Entity<Camp>().HasData(new Camp
            //{
            //    CampId = 1,
            //    Moniker = "ATL2018",
            //    Name = "Atlanta Code Camp",
            //    EventDate = new DateTime(2018, 10, 18),

            //    Location = Lo,
            //    Talks = talkk,
            //    //Location = new Location()
            //    //{
            //    //    LocationId = 1,
            //    //    VenueName = "Atlanta Convention Center",
            //    //    Address1 = "123 Main Street",
            //    //    CityTown = "Atlanta",
            //    //    StateProvince = "GA",
            //    //    PostalCode = "12345",
            //    //    Country = "USA"
            //    //},

            //    Length = 1,
            //    //Talks = new Talk[]
            //    //    {
            //    //    new Talk
            //    //    {
            //    //      TalkId = 1,
            //    //      Title = "Entity Framework From Scratch",
            //    //      Abstract = "Entity Framework from scratch in an hour. Probably cover it all",
            //    //      Level = 100,
            //    //      Speaker = new Speaker
            //    //      {
            //    //        SpeakerId = 1,
            //    //        FirstName = "Shawn",
            //    //        LastName = "Wildermuth",
            //    //        BlogUrl = "http://wildermuth.com",
            //    //        Company = "Wilder Minds LLC",
            //    //        CompanyUrl = "http://wilderminds.com",
            //    //        GitHub = "shawnwildermuth",
            //    //        Twitter = "shawnwildermuth"
            //    //      }
            //    //    },
            //    //    new Talk
            //    //    {
            //    //      TalkId = 2,
            //    //      Title = "Writing Sample Data Made Easy",
            //    //      Abstract = "Thinking of good sample data examples is tiring.",
            //    //      Level = 200,
            //    //      Speaker = new Speaker
            //    //      {
            //    //        SpeakerId = 2,
            //    //        FirstName = "Resa",
            //    //        LastName = "Wildermuth",
            //    //        BlogUrl = "http://shawnandresa.com",
            //    //        Company = "Wilder Minds LLC",
            //    //        CompanyUrl = "http://wilderminds.com",
            //    //        GitHub = "resawildermuth",
            //    //        Twitter = "resawildermuth"
            //    //      }
            //    //    }
            //    //    }
            //}) ; 
        
           
        }


        }
}
