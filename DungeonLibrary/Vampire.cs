using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Vampire : Monster
    {
        

        public DateTime HourChangeBack { get; set; }
        public Vampire()
        {

        }

        public Vampire(int maxLife, int life, string name, int hitChance, int block, int maxDamage, int minDamage, string description, DateTime hourChangeBack)
            : base(maxLife, life, name, hitChance, block, maxDamage, minDamage, description)
        {
            HourChangeBack = DateTime.Now;
            if (HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18)
            {
                hitChance += 10;
                Block += 10;
                MinDamage += 1;
                MaxDamage += 2;
            }


        }

        public override string ToString()
        {
            return base.ToString() + (HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18 ? 
                "Empowered by the night" : "Weakened by the daylight");
        }
    }
}
