﻿using System;
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
            Console.WriteLine("1. Count Coin values");
            Console.WriteLine("2. Determine if the number set is Ascending or Decending");
            Console.WriteLine("3. Decode");
            Console.WriteLine("4. End the program");
            Console.WriteLine("------------------------------------------------------------------");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    path = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in_.txt";
                    CoinCount(path);
                    break;
                case 2:
                    path = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_.txt";
                    DetermineAscendingOrDescending(path);

                    break;
                case 3:
                    path = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in_.txt";
                    Decode(path);
                    break;
                case 4:
                    Console.WriteLine("Thanks for using the program.");
                    break;
                default:
                    break;
            }
        }

        static void CoinCount(string path)
        {
            string s = "";
            float[] a = new float[5];
            StreamReader file = new System.IO.StreamReader(path);
            while ((s = file.ReadLine()) != null)
            {
                int i = 0;
                string[] nArray = s.Split("=");
                foreach (string w in nArray)
                {

                    if(w == "HALFDOLLAR")
                    {
                        a[0] = a[0] + int.Parse(nArray[i + 1]);
                    }
                    else if(w == "QUARTER")
                    {
                        a[1] = a[1] + int.Parse(nArray[i + 1]);
                    }
                    else if(w == "DIME")
                    {
                        a[2] = a[2] + int.Parse(nArray[i + 1]);
                    }
                    else if(w == "NICKEL")
                    {
                        a[3] = a[3] + int.Parse(nArray[i + 1]);
                    }
                    else if(w == "PENNY")
                    {
                        a[4] = a[4] + int.Parse(nArray[i + 1]);
                    }
                    i++;
                }
            }
            Console.WriteLine("$" + (a[0] * 0.5 + a[1] * 0.25 + a[2] * .10 + a[3] * 0.05 + a[4] * 0.01));
        }
        static void DetermineAscendingOrDescending(string path)
        {
            string s = "";
            StreamReader file = new System.IO.StreamReader(path);
            while ((s = file.ReadLine()) != null)
            {
                //Console.WriteLine(s);
                string[] nArray = s.Split(null);
                bool valid = true;
                foreach (string w in nArray)
                {
                    if(w == "-")
                    {
                        valid = false;
                    }
                    foreach (char c in w)
                    {
                        if (!Char.IsNumber(c) && c != '-')
                        {
                            valid = false;
                            //break;
                        }
                    }
                }
                if (valid != true)
                {
                    Console.WriteLine("The input was invalid");
                }
                else if (valid == true)
                {
                    if (int.Parse(nArray[0]) < int.Parse(nArray[1]) && int.Parse(nArray[1]) < int.Parse(nArray[2]) && int.Parse(nArray[2]) < int.Parse(nArray[3]))
                    {
                        Console.WriteLine("The numbers are in ascending order");
                    }
                    else if (int.Parse(nArray[0]) > int.Parse(nArray[1]) && int.Parse(nArray[1]) > int.Parse(nArray[2]) && int.Parse(nArray[2]) > int.Parse(nArray[3]))
                    {
                        Console.WriteLine("The numbers are in descending order");
                    }
                    else
                    {
                        Console.WriteLine("The numbers are in random order");
                    }
                }
                Console.WriteLine("******************************");
            }
        }
        static void Decode(string path)
        {
            string s = "";
            int g=0;
            int k = 0;
            char h;
            //char j;
            char[] n = new char [100];
            string[] wordArray = s.Split(null);
            StreamReader file = new System.IO.StreamReader(path);
            while ((s = file.ReadLine()) != null)
            {
                if (g == 0)
                {
                    foreach (char c in s)
                    {
                        g = c;
                    }
                }
                foreach(string v in wordArray)
                {
                    string[] charArray = s.Split("-");
                    foreach(string l in charArray)
                    {
                        h = (char)(int.Parse(l));
                        n[k] = h;
                    }
                    n.ToString();
                }
                Console.WriteLine(n);
            }
        }
    }
}
