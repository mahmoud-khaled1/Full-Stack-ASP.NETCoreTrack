using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamuraiApp.Domain;
using SamurailApp.Data;
using System.Diagnostics;

namespace SamuraiApp.Test
{
    [TestClass]
    public class DataBaseTest
    {
        [TestMethod]
        public void CanInsertSamuraiIntoDataBase()
        {
            using(var context=new SamuraiContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                var samurai = new Samurai();
                context.Samurais.Add(samurai);
                Debug.WriteLine($"Before save : {samurai.ID}");
                context.SaveChanges();
                Debug.WriteLine($"After save : {samurai.ID}");
                Assert.AreNotEqual(0, samurai.ID);
            }
        }
    }
}
