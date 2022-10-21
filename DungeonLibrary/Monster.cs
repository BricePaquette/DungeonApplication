﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {

        //min damge cant be more than max damage or less than 0
        //Max damage 
        //description
        private int _minDamage;
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = (value > 0 && value <= MaxDamage) ? value : MaxDamage;
            }
        }
        public Monster()
        {

        }

        public Monster(int maxLife, int life, string name, int hitChance, int block, int maxDamage, int minDamage, string description) 
            : base(maxLife, life, name, hitChance, block)
        {
            //remember to set macDamage first! because mindamage wwill reference maxDamage
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

    

        public override int CalcDamage()
        {
            Random rand = new Random();
            int randomDamage = rand.Next(MinDamage, MaxDamage + 1);
            return randomDamage;
        }

       

        public override string ToString()
        {
            return base.ToString() + $"\n{MinDamage} to {MaxDamage} damage potential\n{Description}";
        }
    }
}
