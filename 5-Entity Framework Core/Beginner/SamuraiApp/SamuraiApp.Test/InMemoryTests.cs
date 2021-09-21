using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamuraiApp.Domain;
using SamurailApp.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Test
{
    class InMemoryTests
    {
        public void CanInsertSamuraiIntoDataBase()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("CanInsertSamurai");
            using (var context = new SamuraiContext(builder.Options))
            {
                
                var samurai = new Samurai();
                context.Samurais.Add(samurai);
                //Debug.WriteLine($"Before save : {samurai.ID}");
                //context.SaveChanges();
                //Debug.WriteLine($"After save : {samurai.ID}");
                Assert.AreEqual(EntityState.Added,context.Entry(samurai).State);
            }
        }
    }
}
