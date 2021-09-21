using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
    public class Battle
    {
        public Battle()
        {
            BattleSamurai = new List<BattleSamurai>();   
        }
        public int BattleId { get; set; }
        public string Name { get; set; }
        public List<BattleSamurai> BattleSamurai { get; set; } = new List<BattleSamurai>();
    }
}
