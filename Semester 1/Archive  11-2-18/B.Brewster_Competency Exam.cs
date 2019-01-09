using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            do
            {
                Console.WriteLine();
                Console.WriteLine("***********************************************");
                Console.WriteLine("Type 1 for Conditionals");
                Console.WriteLine("Type 2 for For Loops");
                Console.WriteLine("Type 3 for While Loops");
                Console.WriteLine("Type 4 for Arrays");
                Console.WriteLine("Type 5 for Lists");
                Console.WriteLine("Type -1 to exit");
                Console.WriteLine("***********************************************");
                key = int.Parse(Console.ReadLine());
                int numbers;
                {
                    if (key == 1)
                    {
                        Console.Write("Enter your grade:");
                        int grade = int.Parse(Console.ReadLine());
                        Console.Write("Enter your reading level:");
                        int level = int.Parse(Console.ReadLine());
                        if (grade < 6 && level >= grade)
                        {
                            Console.WriteLine("You are in elementary school and you read at an appropriate level.");
                        }
                        else if (grade < 6 && level < grade)
                        {
                            Console.WriteLine("You are in elementary school.Read more! You don't read at an appropriate level");
                        }
                        else if (grade > 6 && grade < 9 && level >= grade)
                        {
                            Console.WriteLine("You are in middle school and you read at an appropriate level.");
                        }
                        else if (grade > 6 && grade < 9 && level <= grade)
                        {
                            Console.WriteLine("You are in middle school.Read more! You don't read at an appropriate level");
                        }
                        else if (grade >= 9 && grade <= 12 && level >= grade)
                        {
                            Console.WriteLine("You are in high school and you read at an appropriate level.");
                        }
                        else if (grade >= 9 && level <= grade)
                        {
                            Console.WriteLine("You are in high school.Read more! You don't read at an appropriate level");
                        }
                    }
                    if (key == 2)
                    {
                        Console.Write("Enter a number to count by:");
                        int count = int.Parse(Console.ReadLine());
                        Console.Write("Enter a number to count up to by " + count + ":");
                        int up = int.Parse(Console.ReadLine());
                        List<int> countUp = new List<int>();
                        for (int i = -1; i <= up; i++)
                        {
                            i++;
                            Console.WriteLine(i);
                        }
                    }
                    if (key== 3)
                    {
                        Console.WriteLine("Our sum starts at 0. Enter integer values to add to, and print the sum. Enter 0 to stop adding");
                        int sum = int.Parse(Console.ReadLine());
                        int j = 0 + sum;
                        while (sum != 0)
                        {
                            j = j + sum;
                            Console.WriteLine(j);
                            sum = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Your final sum = " + j);
                    }
                    if (key == 4)
                    {
                        int[] array = new int[10];
                        Console.WriteLine("You have an array of size 10 and of type int. Enter values to populate the array.");
                        for (int i= 0; i< array.Length; i++)
                        {
                            int arrayAdd = int.Parse(Console.ReadLine());
                            array[i] = arrayAdd;
                            Console.WriteLine(arrayAdd + " successfully added");

                        }
                        Console.WriteLine("All array values added.Here they are!");
                        Console.WriteLine("index 0 = " + array[0]);
                        Console.WriteLine("index 1 = " + array[1]);
                        Console.WriteLine("index 2 = " + array[2]);
                        Console.WriteLine("index 3 = " + array[3]);
                        Console.WriteLine("index 4 = " + array[4]);
                        Console.WriteLine("index 5 = " + array[5]);
                        Console.WriteLine("index 6 = " + array[6]);
                        Console.WriteLine("index 7 = " + array[7]);
                        Console.WriteLine("index 8 = " + array[8]);
                        Console.WriteLine("index 9 = " + array[9]);
                    }
                    if (key== 5)
                    {
                        List<string> strings = new List<string>();
                        Console.WriteLine("You have a list of type string. Enter values to add to the list.Type end to stop adding and to print out your list.");
                        Console.Write("Enter a string:");
                        string enter = Console.ReadLine();
                        while (enter != "end")
                        {
                            strings.Add(enter);
                            Console.Write("Enter a string:");
                            enter = Console.ReadLine();
                        }
                        strings.ForEach(Console.WriteLine);
                    }
                }
            } while (key != -1);
        }
}
    } 



