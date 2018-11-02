using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 1 to start");
            string letter = new string(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("  _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         ");
            Console.WriteLine(" |        ");
            Console.WriteLine(" |        ");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            //int answer;
            string answer = Console.ReadLine();
            Random rand = new Random();
            string[] easyword = new string[] { "a" }; //{ "hello", "rope", "cope" };
            
            int index = rand.Next(easyword.Length);
            index.Equals(letter);
            //Array 
            //bool check = easyword.Contains("letter");
            
            for (int i = 0, i < easyword.Length; i++) 
            {
                {
                   Console.WriteLine(word[i] = "_");

                }
                if (index.Equals(letter))
                {

                    {
                        int i = 5;
                        Console.WriteLine(i-- + " guesses left");
                        }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("  _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(" |        ");
                    Console.WriteLine(" |        ");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                }
               // if (answer == 2)
                {


                }

            }
        }
    }
}
//Console.WriteLine();
                //Console.WriteLine("  _________");
               // Console.WriteLine(" |         |");
               // Console.WriteLine(" |         0");
                //Console.WriteLine(" |        /|\\");
                //Console.WriteLine(" |        / \\");
               // Console.WriteLine(" |");
                //Console.WriteLine(" |");