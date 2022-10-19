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
        public int Life 
        {
            get { return _life; }
            set
            {
                if (_life <= _maxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = _maxLife;
                }
            }
        }
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

        
        //Constructors
        public Character()
        {
            //Unqualified
        }
        public Character(int maxLife, int life, string name, int hitChance, int block)
        {
            MaxLife = maxLife;
            Life = life;
            Name = name;
            HitChance = hitChance;
            Block = block;
           
        }

        //Methods
        public override string ToString()
        {
            return string.Format($"Name: {Name}\nCurrent Life: {Life}\nMaximum Life: {MaxLife}\nHit Chance: {HitChance}\nBlock: {Block}");
        }
        
        public int CalcBlock()
        {
            return Block;   
        }
        public int CalcDamage()
        {
            return 0;
        }
    }
}