namespace DungeonLibrary
{
    public abstract class Character
    {

        //The "Abstract" modfier denotes this datatype class as "Incomplete" -- we don't intend
        //to make a character object, but will instead use Character as a 
        //Starting point for other, more specific types. More on this later...

        //Fields
        private int _maxLife;
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        

        //Properties
        public int MaxLife { get; set; }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int Life
        {
            get { return _life; }
            set
            {

                _life = value <= MaxLife ? _life = value : MaxLife;

                //if (value <= _maxLife)//prop or field
                //{
                //    _life = value;
                //}
                //else
                //{
                //    _life = MaxLife;
                //}
            }
        }

        //Constructors
        public Character()
        {
            //Unqualified
        }
        public Character(int maxLife, int life, string name, int hitChance, int block)
        {
            MaxLife = maxLife;
            Life = MaxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
           
        }

        //Methods
        public override string ToString()
        {
            //return string.Format($"Name: {Name}\nCurrent Life: {Life}\nMaximum Life: {MaxLife}\nHit Chance: {HitChance}\nBlock: {Block}");
            return $"-----{Name}-----\nLife: {Life} of {MaxLife}\nHit Chance: {HitChance}\nBlock: {Block}\n";
        }
        
        public virtual int CalcBlock()
        {
            return Block;   
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public virtual int CalcDamage()
        {
            return 0;
        }
    }
}