using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
     public class BattleSamurai
     {
        public int SamuraiId { get; set; }
        public int BattleId { get; set; }
        public Samurai Samurai { get; set;}
        public Battle Battle { get; set; }
        public DateTime DateJoined { get; set; }

     }
}
