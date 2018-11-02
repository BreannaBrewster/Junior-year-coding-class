using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What shape do you want to make?:");
                Console.WriteLine("1...1x1 Square");
                Console.WriteLine("2...3x3 Square");
                Console.WriteLine("3...5x5 Square");
                Console.WriteLine("4...Right Triangle");
                Console.WriteLine("5...Backwards Right Triangle");
                Console.WriteLine("6...Pyramid");
                Console.WriteLine("7...Special 1");
                Console.WriteLine("8...Special 2");
                Console.WriteLine("9...Special 3");

                int key;
                key = int.Parse(Console.ReadLine());
                //simple square
                {
                    //1x1 square
                    if (key == 1)
                    {
                        Console.WriteLine("x");
                    }
                    //3x3 Square
                    if (key == 2)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (true)
                                    Console.Write("x");
                            }
                            Console.WriteLine();
                        }
                    }
                    //5x5 Square
                    if (key == 3)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (true)
                                    Console.Write("x");
                            }
                            Console.WriteLine();
                        }
                    }
                    //Right Triangle
                    if (key == 4)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (i >= j)
                                    Console.Write("x");
                                else
                                    Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                    }
                    //Backwards Right Triangle
                    if (key == 5)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (j + i <= 4)
                                    Console.Write(" ");
                                else
                                    Console.Write("x");
                            }
                            Console.WriteLine();
                        }
                    }
                        //Pyramid
                        if (key == 6)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if (i + j <= 1)
                                        Console.Write(" ");
                                    else if (i <= j - 3)
                                        Console.Write(" ");
                                    else
                                        Console.Write("x");
                                }
                                Console.WriteLine();
                            }
                        }
                    //Special 1
                    if (key == 7)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (i == j)
                                    Console.Write(" ");
                                else
                                    Console.Write("x");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                //Special 2
                if (key == 8)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j + i == 4)
                                Console.Write(" ");
                            else
                                Console.Write("x");
                        }
                        Console.WriteLine();
                    }

                }
                if (key == 9)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j + i == 4)
                                Console.Write(" ");
                            else if (j == i)
                                Console.Write(" ");
                            else
                                Console.Write("x");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

    }
}
