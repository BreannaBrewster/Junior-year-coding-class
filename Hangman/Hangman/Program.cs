using System;
using System.Collections.Generic;
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Type 1 to start single word hangman");
            Console.WriteLine("Type 2 to start phrase hangman");
            Console.WriteLine("Type 4 to close");
            int letter = int.Parse(Console.ReadLine());
            Random rand = new Random();
            var choose = rand.Next(0, 19);
            string[] word = new string[20] { "charge", "direction", "drip", "haircut", "stimulating", "savory", "grape", "ruthless", "ski", "boring", "eggnog", "regret", "clear", "rat", "flow", "announce", "skillful", "icicle", "kettle", "phobic" };
            string[] phrase = new string[20] {"go ahead, make my day", "the stuff that dreams are made of", "there's no place like home", "you can't handle the truth!", "nobody expects the spanish inquisition!", "tis but a scratch", "bring forth the holy hand granade!", "what was it like being a hamster?", "you don’t have to live forever, you just have to live", "not all those who wander are lost", "beware for i am fearless, and therefore powerful", "i am not afraid of storms, for i am learning how to sail my ship", "and the rest is rust and stardust", "books keep stupidity at bay", "seek freedom and become captive of your desires, seek discipline and find your liberty", "great men are not born great. they grow great", "humanity does not ask us to be happy. it merely asks us to be brilliant on its behalf", "it takes something more than intelligence to act intelligently","and in that moment i swear we were infinite", "how much love inside a friend? depends how much you give ’em"};           
            List<char> guesses = new List<char>(' ');
            string choosenWord = " ";
            char[] guess = new char[choosenWord.Length];
            if (letter == 1)
            {
                choosenWord = word[choose];
                guess = new char[choosenWord.Length];
            }
            if (letter == 2)
            {
                choosenWord = phrase[choose];
                guess = new char[choosenWord.Length];
            }
                Console.WriteLine();
                Console.WriteLine("  _________");
                Console.WriteLine(" |         |");
                Console.WriteLine(" |         ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                
                int w = 0;
                int lives = 6;
                bool won = false;
                /////index out of array
                for (int q = 0; q < choosenWord.Length; q++)
                {
                    if (choosenWord[q] == ' ' || choosenWord[q] == '.' || choosenWord[q] == ','|| choosenWord[q] == '?' ||  choosenWord[q] == '!')
                    {
                        Console.Write(choosenWord[q]);
                    }
                    else
                    {
                        guess[q] = '_';
                        Console.Write(guess[q] + " ");
                    }
                }

                while (!won && lives > 0)
                {
                    int k = 0;
                    int q = 0;
                    Console.WriteLine();
                    Console.Write("You've guessed: ");
                    foreach (char c in guesses)
                    {
                        Console.Write(c.ToString() + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("What is your letter?");
                    char answer = char.Parse(Console.ReadLine());
                    guesses.Add(answer);
                    for (int i = 0; i < choosenWord.Length; i++)
                    {
                        //if there is a match between the user input and the choosen word
                        if (answer == choosenWord[i] )
                        {
                            guess[i] = answer;
                        }
                        else if(answer != choosenWord[i])
                        {
                            q++;
                        }
                        if(q >= choosenWord.Length)
                        {
                          lives = lives - 1;
                        }
                        Console.Write(guess[i] + " ");
                        if(guess[i] != '_')
                        {
                            k++;
                        }
                    }
                    
                if (k>= choosenWord.Length)
                    {
                        won = true;
                    }

                    if (lives == 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("  _________");
                        Console.WriteLine(" |         |");
                        Console.WriteLine(" |         ");
                        Console.WriteLine(" |        ");
                        Console.WriteLine(" |        ");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                    }

                    else if (lives ==5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("  _________");
                        Console.WriteLine(" |         |");
                        Console.WriteLine(" |         0");
                        Console.WriteLine(" |        ");
                        Console.WriteLine(" |        ");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                    }
                    else if (lives == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine("  _________");
                        Console.WriteLine(" |         |");
                        Console.WriteLine(" |         0");
                        Console.WriteLine(" |         |");
                        Console.WriteLine(" |        ");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                    }
                    else if (lives == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("  _________");
                        Console.WriteLine(" |         |");
                        Console.WriteLine(" |         0");
                        Console.WriteLine(" |        /|");
                        Console.WriteLine(" |        ");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                    }
                    else if (lives == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("  _________");
                        Console.WriteLine(" |         |");
                        Console.WriteLine(" |         0");
                        Console.WriteLine(" |        /|\\");
                        Console.WriteLine(" |        ");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                    }
                    else if (lives == 1 )
                    {
                        Console.WriteLine();
                        Console.WriteLine("  _________");
                        Console.WriteLine(" |         |");
                        Console.WriteLine(" |         0");
                        Console.WriteLine(" |        /|\\");
                        Console.WriteLine(" |        / ");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                    }
                    
                    //Console.Clear();
                }
                //win screen(broken)
                if (won == true)
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("          ");
                    Console.WriteLine("           0/");
                    Console.WriteLine("          /|");
                    Console.WriteLine("          / \\");
                }
                else if (lives == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("  _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(" |        /|\\");
                    Console.WriteLine(" |        / \\");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("You loose. The answer was " + choosenWord);
    
                }
            
        }
    }
}
