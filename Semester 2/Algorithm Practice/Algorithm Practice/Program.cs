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
                    CoinCount();
                    break;
                case 2:
                    Console.WriteLine("Please enter the number of elements you want to add to the array:");
                    int k = int.Parse(Console.ReadLine());
                    List<int> f = new List<int>();
                    bool valid = true;
                    for (int i = 0; i < k; i++)
                    {
                        Console.Write("What value do you want to add?");
                        string s= Console.ReadLine();
                    }
                    

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
            Console.WriteLine("Please enter the lower bound to check multiples:");
        }
        static void DetermineAscendingOrDescending(bool valid, List<float> f )
        {
            if(valid==false)
            {
                Console.WriteLine("The input was invalid");
            }
            else
            {
                foreach(int i in f)
                {
                    if(i<i+1 && i+1<i+2)
                    {
                        Console.WriteLine("The numbers are in decending order");
                    }
                    else if (i > i + 1 && i + 1 > i + 2)
                    {
                        Console.WriteLine("The numbers are in ascending order");
                    }
                    else
                    {
                        Console.WriteLine("The numbers are in random order");
                    }
                }
            }
        }
        static void FillList(bool valid, List<int> f, string s)
        {
            foreach(char c in s.ToCharArray())
            {
                if(!Char.IsDigit(c) && c!= '-')
                {
                    valid = false;
                }
                else
                {
                    f.Add(c);
                }
            }
            
        }
    }
}
