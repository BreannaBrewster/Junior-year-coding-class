using System;
using System.Collections.Generic;
using System.IO;

namespace BBrewster_Character_save_load
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            string n;
            
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
                if (answer == 1)
                {
                    characters.Add(CreateCharacter());
                    
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
        static Character CreateCharacter()
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
            Console.Write("Sucess! " + n + ". Your health is 100");
            Console.WriteLine();
            SaveCharacter(newcharacter);
            return newcharacter;
        }
        static void ModifyCharacter(Character character)
        {

        }
        static void SaveCharacter(Character newCharacter)
        {
            string path = @"C:\Users\186741\Documents\Junior-year-coding-class\BBrewster Character saveload\BBrewster Character saveload\bin\Debug\netcoreapp2.1\Character.txt";
            path = AppDomain.CurrentDomain.BaseDirectory + @"Character.txt";
            List<Character> characters = new List<Character>();
            characters.Add(newCharacter);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(newCharacter);
            }
            

        }
        //bool DeleteCharacter(List<Character> characters, string n)
        //{

        //}
    }
}
