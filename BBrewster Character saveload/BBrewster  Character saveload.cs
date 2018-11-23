using System;
using System.Collections.Generic;

namespace BBrewster__Character_saveload
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            string n;
            path = @"C:\Users\186741\Documents\Junior-year-coding-class\Archive  11-2-18\IO\IO\bin\Debug\netcoreapp2.1\Example.txt";
            path = AppDomain.CurrentDomain.BaseDirectory + @"Example.txt";
            List<Character> characters = new List<Character>();
            do
            {
            Console.WriteLine("*******press********");
            Console.WriteLine("1.Create a character");
            Console.WriteLine("2.Modify a character");
            Console.WriteLine("3.Delete a character");
            Console.WriteLine("4.Load existing characters");
            Console.WriteLine("5.List characters");
            Console.WriteLine("6.Exit");
            answer = int.Parse(Console.ReadLine());
            if(answer == 1)
            {
                    CreateCharacter();
                    SaveCharacter(character);
                }
            if (answer == 2)
            {

            }
            if (answer == 3)
            {

            }
            if (answer == 4)
            {

            }
            if (answer == 5)
            {

            }
            } while (answer != 6);
        }
       static void CreateCharacter()
        {
            int h = 100;
            Console.Write("What is your name?: ");
            string n = Console.ReadLine();
            Console.Write("What is your intelligence?: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your strength?: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your luck?: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Character newcharacter = new Character(n, i, s, h, l);
            Console.WriteLine();
            
        }
        static void ModifyCharacter(Character character)
        {

        }
        static void SaveCharacter(Character CreateCharacter, Character newCharacter)
        {
            Console.Write("Sucess! " + n + ". Your health is 100");
            List<Character> characters = new List<Character>();
            characters.Add(newCharacter);
            Console.WriteLine(characters);

        }
        //bool DeleteCharacter(List<Character> characters, string n)
        //{

        //}
    }
}
