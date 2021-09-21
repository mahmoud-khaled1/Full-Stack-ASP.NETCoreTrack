using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
   public class Samurai
    {
        public Samurai()
        {
            Quotes = new List<Quote>();
            BattleSamurai = new List<BattleSamurai>();
        }
        public int ID{ get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } = new List<Quote>();
        public List<BattleSamurai> BattleSamurai { get; set; } = new List<BattleSamurai>();
        public Horse Horse { get; set; }
    }
}
