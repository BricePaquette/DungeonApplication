using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {


        //minDamage – int

        //maxDamage – int

        //name – string

        //bonusHitChance – int

        //isTwoHanded - bool



        //Full Qualified CTOR

        //Nicely Formatted ToString()

        //Include a business rule that ensures MinDamage is less than or equal to MaxDamage.
        //If someone tries to assign a value greater than MaxDamage, then assign MinDamage the value of MaxDamage.
        //In the body of the Fully Qualified Constructor, ensure that the assignment for MaxDamage happens before MinDamage.

        //Fields
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;


        //Properties
        public int MaxDamge
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }

        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int MinDamge 
        {
        get { return _minDamage; }
            set 
            {
               _minDamage = (value > 0 && value <= MaxDamge) ? value : 1;
            
            }
        
        }
        //Constructors
        public Weapon()
        {

        }
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            _maxDamage = maxDamage;
            _minDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            type = Type;
            
        }

        //Methods()
        public override string ToString()
        {
            return string.Format($"Name: {Name}\t{MinDamge} to {MaxDamge} Damage\nBonus Hit Chance: {BonusHitChance}\nTwo Handed?: {IsTwoHanded}\nWeapon type: {Type}\n");
        }


        
    }
}
