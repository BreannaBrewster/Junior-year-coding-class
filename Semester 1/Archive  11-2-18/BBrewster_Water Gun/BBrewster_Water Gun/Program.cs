using System;

namespace BBrewster_Water_Gun
{
    class Program
    {
        static void Main(string[] args)
        {
            Player1();
            Player2();
        }
        static void Player1()
        { 
            WaterGun Player1 = new WaterGun();
            Console.WriteLine("Press 1 to load");
            Console.WriteLine("Press 2 to shoot");
            int key1 = int.Parse(Console.ReadLine());
            if (key1 == 1)
            {

            }
        }
        static void Player2()
        {
            WaterGun Player2 = new WaterGun();
            Console.WriteLine("Press 1 to load");
            Console.WriteLine("Press 2 to shoot");
            int key2 = int.Parse(Console.ReadLine());
            if (key2 == 1)
            {

            }

        }
    }
    
}
