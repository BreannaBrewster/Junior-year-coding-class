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
                    LoadCharacters();
                    Console.Write("What is your character's name?: ");
                    string characterName = Console.ReadLine();
                    Console.WriteLine("Welcome back" + characterName + " your stats are:");
                    LoadCharacter(characterName);
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
        static void VerifyCharacter(Character characterName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + characterName.name + ".txt";
            if (File.Exists(path))
            {
                if (Console.ReadLine()[0] == 'y' || Console.ReadLine()[0] == 'Y')
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(characterName.name);
                        sw.WriteLine(characterName.intelligence);
                        sw.WriteLine(characterName.strength);
                        sw.WriteLine(characterName.health);
                        sw.WriteLine(characterName.luck);
                    }
                }
            }
        }
        static void SaveCharacter(Character newCharacter)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory +newCharacter.name +".txt";
            if (File.Exists(path))
            {
                Console.Write("This character already exists. Do you want to overwrite it?(y/n):");
                if (Console.ReadLine()[0] == 'y' || Console.ReadLine()[0] == 'Y')
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(newCharacter.name);
                        sw.WriteLine(newCharacter.intelligence);
                        sw.WriteLine(newCharacter.strength);
                        sw.WriteLine(newCharacter.health);
                        sw.WriteLine(newCharacter.luck);
                    }
                }
                else
                {
                    Console.WriteLine("Character not overwritten");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(newCharacter.name);
                    sw.WriteLine(newCharacter.intelligence);
                    sw.WriteLine(newCharacter.strength);
                    sw.WriteLine(newCharacter.health);
                    sw.WriteLine(newCharacter.luck);
                }
            }
        }
        static Character LoadCharacter(string characterName)
        {
            string n = " ";
            int i = 0;
            int s = 0;
            int l= 0;
            int h = 0;
            string path = AppDomain.CurrentDomain.BaseDirectory + characterName + ".txt";
            using (StreamReader sr = new StreamReader(path))
            {
                for(int j=0; j<6; j++)
                {
                    if (j == 1)
                    {
                        n = sr.ReadLine();
                    }
                    else if (j == 2)
                    {
                        i = Convert.ToInt32(sr.ReadLine());
                    }
                    else if (j == 3)
                    {
                        s = Convert.ToInt32(sr.ReadLine());
                    }
                    else if (j == 4)
                    {
                        h = Convert.ToInt32(sr.ReadLine()); ;
                    }
                    else if (j == 5)
                    {
                        l = Convert.ToInt32(sr.ReadLine());
                    }
                }

            }
            Character newCharacter = new Character(n, i, s, h, l);
            Console.WriteLine(newCharacter.name);
            Console.WriteLine(newCharacter.intelligence);
            Console.WriteLine(newCharacter.strength);
            Console.WriteLine(newCharacter.health);
            Console.WriteLine(newCharacter.luck);
            return newCharacter;
        }
        static List<Character> LoadCharacters()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            List<Character> characters = new List<Character>();
            string[] characterFiles = Directory.GetFiles(path, "*.txt");
            for (int i = 0; i < characterFiles.Length; i++)
            {
                characterFiles[i] = Path.GetFileName(characterFiles[i]);
                
            }
            foreach(var c in characters)
            {

            }
            return LoadCharacters();
        }
        static void PrintAllCharacters(List<Character> characters)
        {
            foreach (Character c in LoadCharacters())
            {
                Console.WriteLine(c);
            }
        }
            
        //}
        //bool DeleteCharacter(List<Character> characters, string n)
        //{

        //}
    }
}
