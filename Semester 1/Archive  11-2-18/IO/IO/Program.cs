using System;
using System.IO;
namespace IO
{
    class Program
    {
        static void Main(string[] args)
        { 
            int choice =0;
            while (choice != 4)
            {
                Random rand = new Random();
                Console.WriteLine("Press 1 to save a random array to a file");
                Console.WriteLine("Press 2 to Load a random array from a file");
                Console.WriteLine("Press 4 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
                string path;
                path = @"C:\Users\186741\Documents\Junior-year-coding-class\Archive  11-2-18\IO\IO\bin\Debug\netcoreapp2.1\Example.txt";
                path = AppDomain.CurrentDomain.BaseDirectory + @"Example.txt";
                if (choice == 1)
                {
                    Console.WriteLine("How large you you want the array?");
                    int w = Convert.ToInt32(Console.ReadLine());
                    int[] intArray = new int[w];
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        intArray[i] = rand.Next(0, rand.Next(0, 10000));
                    }
                    Console.WriteLine("Press 1 for a 1D array");
                    Console.WriteLine(" press 2 for a 2D array");
                    choice = Convert.ToInt32(Console.ReadLine());


                    if (choice == 1)
                    {
                        
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            for (int i = 0; i < intArray.Length; i++)
                            {
                                sw.WriteLine(intArray[i]);
                            }
                            sw.Dispose();
                        }
                    }
                    else if (choice == 2)
                    {
                        int t = 0;
                        Console.WriteLine("How many columns do you want?");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How many rows do you want?");
                        int y = Convert.ToInt32(Console.ReadLine());
                        int[,] array = new int[x, y];
                        
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    if (t > intArray.Length)
                                    {
                                        sw.Write(intArray[t] + " |");
                                        t++;
                                    }
                                }
                                sw.ToString();
                                sw.WriteLine();
                            }
                            sw.Dispose();
                        }
                    }
                }
                else if (choice == 2)
                {
                    //List<string> file = new List<string>();
                    string result;
                    
                    using (StreamReader sr = new StreamReader(path))
                    {
                        result = sr.ReadLine();
                    }
                }
            }
        }
    }
}
