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
            Console.WriteLine("1. Count Coin values");
            Console.WriteLine("2. Determine if the number set is Ascending or Decending");
            Console.WriteLine("3. Factor");
            Console.WriteLine("4. Scantron Grading");
            Console.WriteLine("5. End the program");
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
                    path = AppDomain.CurrentDomain.BaseDirectory + @"Prob04.in_.txt";
                    Factor(path);
                    break;
                case 4:
                    path = AppDomain.CurrentDomain.BaseDirectory + @"Prob05.in_.txt";
                    ScantronGrading(path);
                    break;
                case 5:
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
        static void Factor (string path)
        {
            string s = "";
            List<int> l1 = new List<int>();
            int A=1;
            StreamReader file = new System.IO.StreamReader(path);
            while ((s = file.ReadLine()) != null)
            {
                for (int i = int.Parse(s); i > 0; i--)
                {
                   if( !l1.Contains(i))
                    {
                        l1.Add(i);
                        A = A * i;
                    } 
                }
                Console.WriteLine(A);
            }
        }
        static void ScantronGrading(string path)
        {
            string s = "";
            string[] h = new string[] { " " };
            int q = -1;
            int f = 0;
            int g = 0;
            int correct = 0;
            int line = 0;
            List<string> answer = new List<string>();
            List<string> students = new List<string>();
            List<int> grade = new List<int>();
            StreamReader file = new System.IO.StreamReader(path);
            while ((s = file.ReadLine()) != null)
            {
                if (f == 0)
                {
                    f = int.Parse(s);
                }
                //Console.WriteLine(s);
                h = s.Split(null);
                if (h[0] == "STUDENT")
                {
                    q++;
                    line = 0;
                    correct = 0;
                    students.Add(s);
                    grade.Add(g * 20);
                }
                if (f != 0 && q == -1)
                {
                    answer.Add(s);
                }
                else
                {
                    if (s == answer[line])
                    {
                        correct = correct + 1;
                    }
                    line++;
                }
                g = correct;
            }
            grade[q]=grade[q] + (g * 20);
            for (int n = 1; n < students.Count; n++)
            {
                Console.WriteLine(students[n] + ": " + grade[n]);
            }
        }
    }
}

