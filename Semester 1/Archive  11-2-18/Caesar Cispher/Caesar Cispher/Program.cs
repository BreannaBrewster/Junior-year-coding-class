using System;

namespace ConsoleApp4
{
    class Program
    {
        public static char cipher(char c, int key)
        {
            if (!char.IsLetter(c))
            {
                return c;
            }
            char a = char.IsUpper(c) ? 'A' : 'a';
            return (char)(((c + key - a) % 26) + a);
        }
        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }
        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.WriteLine("Type 1 to cipher");
                Console.WriteLine("Type 2 to decipher");
                Console.WriteLine("Type 3 to decipher with brute force");
                Console.WriteLine("Type 4 to close program");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Type a sentence to encrypt:");
                    string sentence = Console.ReadLine();

                    Console.WriteLine("\n");

                    Console.Write("Enter your Shift: ");
                    int key = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n");

                    Console.WriteLine("Encrypted Data");

                    string cipherText = Encipher(sentence, key);
                    Console.WriteLine(cipherText);
                    Console.Write("\n");
                }
                else if (input == 2)
                {
                    Console.Write("Enter Encrypted text: ");
                    string cipherText = Console.ReadLine();
                    Console.Write("Enter the shift number: ");
                    int key = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Decrypted Data:");
                    string t = Decipher(cipherText, key);
                    Console.WriteLine(t);
                    Console.Write("\n");
                }
                else if (input == 3)
                {
                    Console.Write("Enter Encrypted text: ");
                    string cipherText = Console.ReadLine();
                    Console.WriteLine("Decrypted Data:");
                    for (int i = 0; i < 27; i++)
                    {
                        int key = i;
                        string t = Decipher(cipherText, key);
                        Console.WriteLine(t);
                        Console.Write("\n");
                    }

                }
                else
                {
                    Console.Write("Enter a valid number");
                }
            } while (input != 4);
        }

    }
}