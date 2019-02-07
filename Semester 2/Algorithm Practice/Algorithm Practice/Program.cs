using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Please enter an integer value for the action you want to perform.");
            Console.WriteLine("1. Print all multiples of 3 or 5 between selected values.");
            Console.WriteLine("2. Create an array of n random integers.");
            Console.WriteLine("3. Convert Fahrenheit to Celsius.");
            Console.WriteLine("4. End the program");
            Console.WriteLine("------------------------------------------------------------------");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    path = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.txt";
                    CoinCount();
                    break;
                case 2:
                    path = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.txt";
                    DetermineAscendingOrDescending();



                    break;
                case 3:
                    Console.WriteLine("Please enter a floating point number representing Fahrenheit:");
                    
                    break;
                case 4:
                    Console.WriteLine("Thanks for using the program.");
                    break;
                default:
                    break;
            }
        }

        static void CoinCount()
        {
            
        }
        static void DetermineAscendingOrDescending()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in_.txt";
            string s = "";
            int[] i = new int[30];
            int d = 0;
            StreamReader file = new System.IO.StreamReader(path);
            while ((s = file.ReadLine()) != null)
            {
                string[] nArray = s.Split(null);
                foreach (string w in nArray)
                {
                    d++;
                    bool valid = true;
                    foreach (char c in w)
                    {
                        if (Char.IsDigit(c) )
                        {
                            Console.WriteLine("The input was valid");
                            //valid = false;
                            break;
                        }
                    }
                    if (valid == true)
                    {
                        i[d] = int.TryParse(w, out number );
                    }
                }
            }
            
            if (i[0] < i[1] && i[1] < i[2] && i[2] < i[3])
            {
                Console.WriteLine("The numbers are in ascending order");
            }
            else if (i[0] > i[1] && i[1] > i[2] && i[2] > i[3])
            {
                Console.WriteLine("The numbers are in descending order");
            }
            else
            {
                if (i[0] < i[1] && i[1] < i[2] && i[2] < i[3])
                {
                    Console.WriteLine("The numbers are in random order");
                }
            }
            
        }
    }
}
