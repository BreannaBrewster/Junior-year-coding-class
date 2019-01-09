using System;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            //char[] alpha = new char[] { 'abcdefghijklmnopqrstuvwxyz' };
            Console.WriteLine("Type 1 to start");
            Console.WriteLine("Type 4 to close");
            int letter;
            letter = int.Parse(Console.ReadLine());
            Random rand = new Random();
            string[] choosenWord = new string[20]{ "charge", "direction","drip","haircut","stimulating","savory","grape","ruthless","ski", "boring","eggnog","regret","clear","rat","flow","announce","skillful","icicle","kettle","phobic"};
            char[] wordChar = new char[rand.Next(choosenWord.Length)];
            char[] spaces = new char[wordChar.Length];
            int k = 0;
            //Array 
            if (letter == 1)
            {
                
                Console.WriteLine();
                Console.WriteLine("  _________");
                Console.WriteLine(" |         |");
                Console.WriteLine(" |         ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                int i = 0;
                for (int j = 0; j < 7; j++)
                {
                    /////index out of array
                    for (i=0; i < wordChar.Length; i++)
                    {
                        spaces[i] = '_';
                        Console.Write(spaces[i] +" ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("What is your letter?");
                    string answer = Console.ReadLine();
                    char[] answerCharArray = answer.ToCharArray();
                    char answerChar = answerCharArray[0];
                    for(i =0; i <answerChar; i++)
                    {
                        string[] letters = new string[8];
                        Console.WriteLine();
                        Console.WriteLine("What is your letter?");
                        answer = Console.ReadLine();
                        answerCharArray = answer.ToCharArray();
                        answerChar = answerCharArray[0];
                        //letters = new string[] { };
                        //checks each character in choosenWord
                        //foreach (char c in choosenWord)
                        for (i = 0; i < wordChar.Length; i++)
                        {
                            for (i = 0; i < wordChar.Length; i++)
                            {
                                //if there is a match between the user input and the choosen word
                                if (answerChar == wordChar[i])
                                {
                                    letters[i] = answerChar.ToString();
                                    spaces[i] = answerChar;
                                    Console.Write(spaces[i]);
                                }
                                else if (answerChar != wordChar[i])
                                {
                                    letters[i] = answerChar.ToString();
                                    //Console.Write(spaces[i]);
                                    k++;
                                }
                            }
                            
                            //if there is a match between the user input and the choosen word
                            for (i = 0; i< wordChar.Length; i++)
                            {
                                Console.WriteLine(wordChar[i]);
                                if (answerChar == wordChar[i])
                                {
                                    wordChar[i] = answerChar;
                                    Console.Write(wordChar[i]);
                                }
                                else if (answerChar != wordChar[i])
                                {
                                    Console.Write(spaces[i]);
                                    k++;
                                }
                            }
                            Console.Write(letters[i]);
                        }
                        if (k == wordChar.Length)
                        {
                            j++;
                        }
                        //win screen(broken)
                        //if (answer == choosenWord)
                        {
                            // Console.WriteLine("You win!");
                            // Console.WriteLine();
                            // Console.WriteLine(" ");
                            // Console.WriteLine("          ");
                            //Console.WriteLine("           0//");
                            //Console.WriteLine("          /|");
                            //Console.WriteLine("         / \\");

                        }
                        //wrong guesses = advancement of hanging
                        if (j == 0)
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

                        else if (j == 1)
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
                        else if (j == 2)
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
                        else if (j == 3)
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
                        else if (j == 4)
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
                        else if (j == 5)
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
                        else if (j == 6)
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
        }
    }
}

//Console.WriteLine();
//Console.WriteLine("  _________");
// Console.WriteLine(" |         |");
// Console.WriteLine(" |         0");
//Console.WriteLine(" |        /|\\");
//Console.WriteLine(" |        / \\");
// Console.WriteLine(" |");
//Console.WriteLine(" |");