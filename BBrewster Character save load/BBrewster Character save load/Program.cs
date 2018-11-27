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
                    Console.Write("What is your character's name?: ");
                    string characterName = Console.ReadLine();
                    LoadCharacter(characterName);
                    Console.WriteLine("Welcome back" + characterName + " your stats are:");
                    Console.WriteLine(newCharacter.name);
                    Console.WriteLine(newCharacter.intelligence);
                    Console.WriteLine(newCharacter.strength);
                    Console.WriteLine(newCharacter.health);
                    Console.WriteLine(newCharacter.luck);
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
            Character newCharacter = new Character(n, i, s, h, l);
            Console.Write("Sucess! " + n + ". Your health is 100");
            Console.WriteLine();
            SaveCharacter(newCharacter);
            return newCharacter;
            
        }
        static void ModifyCharacter(Character character)
        {

        }
        static void SaveCharacter(Character newCharacter)
        {
            string path = @"C:\Users\186741\Documents\Junior-year-coding-class\BBrewster Character saveload\BBrewster Character saveload\bin\Debug\netcoreapp2.1\Character.txt";
            path = AppDomain.CurrentDomain.BaseDirectory + @"Character_" + newCharacter.name +".txt";
            List<Character> characters = new List<Character>();
            characters.Add(newCharacter);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(newCharacter.name);
                sw.WriteLine(newCharacter.intelligence);
                sw.WriteLine(newCharacter.strength);
                sw.WriteLine(newCharacter.health);
                sw.WriteLine(newCharacter.luck);
            }
        }
        static Character LoadCharacter(string characterName)
        {
            string n = " ";
            int i = 0;
            int s = 0;
            int l= 0;
            int h= 0;
            string path = @"C:\Users\186741\Documents\Junior-year-coding-class\BBrewster Character saveload\BBrewster Character saveload\bin\Debug\netcoreapp2.1\Character.txt";
            path = AppDomain.CurrentDomain.BaseDirectory + @"Character_" + characterName + ".txt";
            using (StreamReader sr = new StreamReader(path))
            {
                for(int j=0; j<6; j++)
                {
                    if (j == 1)
                    {
                        n = Console.ReadLine();
                    }
                    else if (j == 2)
                    {
                        i = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (j == 3)
                    {
                        s = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (j == 4)
                    {
                        h = 100;
                    }
                    else if (j == 5)
                    {
                        l = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            Character newCharacter = new Character(n, i, s, h, l);
            return newCharacter;
        }
        //List<Character> LoadCharacters()
        //{
            //using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory))
            //{
                //namespace.Contains(".txt")
            //}
            
        //}
        //bool DeleteCharacter(List<Character> characters, string n)
        //{

        //}
    }
}
