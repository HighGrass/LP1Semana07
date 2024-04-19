namespace GameUnits
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public override int Health { get { return base.Health + XP; } }
        public override float Cost { get { return base.Cost + XP; } }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        { // Unit(int, int)
            XP = 0;
            AttackPower = attackPower;
        }

        public void Attack(Unit u)
        {
            this.XP++;
            u.Health -= AttackPower;
        }
        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower} XP={XP}";
        }
    }
}
