using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Code_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem2();
        }
        static void Problem1()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in.txt";
            StreamReader file = new System.IO.StreamReader(path);
            string s;
            List<int> l = new List<int>();
            while ((s = file.ReadLine()) != null)
            {
                string[] f = s.Split(",");
                foreach (string v in f)
                {
                    l.Add(int.Parse(v));
                }
                List<int> w = l.OrderBy(t => t).ToList();
                foreach (int i in w)
                {
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
        }
        static void Problem2()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in.txt";
            StreamReader file = new System.IO.StreamReader(path);
            string s;
            while ((s = file.ReadLine()) != null)
                { //if(new string(s.Reverse().ToArray())==s)
                {
                    Console.WriteLine(s.Reverse().ToArray());

                }

            }
        }
    }
}
