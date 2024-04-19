using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            SettlerUnit settler = new SettlerUnit();
            MilitaryUnit military = new MilitaryUnit(2, 100, 20);

            Console.WriteLine(settler.ToString());
            Console.WriteLine("Settler Health: " + settler.Health);
            Console.WriteLine("Settler Cost: " + settler.Cost);
            settler.Move();

            Console.WriteLine(military.ToString());
            Console.WriteLine("Military Health: " + military.Health);
            Console.WriteLine("Military Cost: " + military.Cost);
            military.Move();

            
        }
    }
}