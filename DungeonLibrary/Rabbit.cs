using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Rabbit : Monster
    {
        public bool IsFluffy { get; set; }

        public Rabbit()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Baby Rabbit";
            Life = MaxLife;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "It's just a cute little bunny why would you hurt it?";
            IsFluffy = false;

            
        }

        public Rabbit(int maxLife, int life, string name, int hitChance, int block, // Character
                      int maxDamage, int minDamage, string description, // Monster
                      bool isFluffy)  // Rabbit
            : base(maxLife, life, name, hitChance, block, maxDamage, minDamage, description)//using the assignment in the ctor of monster
        {
            IsFluffy = isFluffy;
        }

        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "It's fluffy! :)" : "It's not so fluffy :(");
        }
        //Character CalcBlock = block
        //Monster CalcBlock = block
        //Rabbit CalcBlock = not block

        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            //Apply a 50% icrease to theabbits if its fluffy
            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }
}
