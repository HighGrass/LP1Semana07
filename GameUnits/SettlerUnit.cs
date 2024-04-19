namespace GameUnits
{
    class SettlerUnit : Unit
    {
        public int movement;
        public int health;
        
        public override float Cost { get { return 5; } }
        public SettlerUnit() : base(1, 1)
        {
            movement = 1;
            health = 1;
        }
    }
}