using System;

namespace ConsoleApp1
{
    class Program
    {
        static int answer = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Press (1) to find out what 5+6 equals");
            Console.WriteLine("Press (2) to find out what 11+13 equals");
            Console.WriteLine("Press (3) to find out what 3+9 equals");
            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                One();
            }
            if (answer == 2)
            {
                Two();
            }
            if (answer == 3)
            {
                Three();
            }
        }
        static void One()
        {
            int i = 5 + 6;
            Console.WriteLine(i);
        }
        static void Two()
        {
            int i = 11 + 13;
            Console.WriteLine(i);
        }
        static void Three()
        {
            int i = 3 + 9;
            Console.WriteLine(i);
        }
    }
}


