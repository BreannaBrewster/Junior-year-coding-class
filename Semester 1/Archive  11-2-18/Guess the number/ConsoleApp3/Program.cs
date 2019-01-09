using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int intList = rand.Next(0, 1001);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("What is your number?");
                int guess = int.Parse(Console.ReadLine());
                int[] numb = new int[6];
                numb[i] = guess;
                numb[i] = ((i+5)-i*2);
                if (guess > intList)
                {
                    Console.WriteLine("too high.");
                    Console.WriteLine(numb[i] + " guesses left");
                }
                else if (guess < intList)
                {
                    Console.WriteLine("too low");
                    Console.WriteLine(numb[i] + " guesses left");
                }
                else if (guess == intList)
                {
                    Console.WriteLine("correct");
                    
                    Console.WriteLine(numb[i] + " guesses left");
                }
            }
            Console.WriteLine("No more guesses left. The number was " + intList);
            Console.ReadKey();
        }
    }
}
