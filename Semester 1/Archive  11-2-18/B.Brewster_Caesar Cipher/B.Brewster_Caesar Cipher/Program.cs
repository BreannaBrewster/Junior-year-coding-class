using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 to cipher");
            Console.WriteLine("Press 2 to decipher");
            int num = int.Parse(Console.ReadLine());
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char myChar;
            int myInt;
            for (int i = 0; i < alpha.Length; i++)
            {
                myChar = alpha[i];
                myInt = myChar;
                Console.WriteLine(myChar + " = " + myInt);
            }
            if (num == 1)
            {
                Console.WriteLine("What is your shift?");
                num = int.Parse(Console.ReadLine());
                for (int i = 0; i < alpha.Length; i++)
                {
                    myChar = alpha[i];
                    myInt = myChar;
                    int cipher = myInt + num;
                    Console.WriteLine(myChar + " = " + cipher);
                }
            }
        }
    }
}