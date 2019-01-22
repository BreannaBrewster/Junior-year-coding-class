using System;
using System.Collections.Generic;
using Abstraction_and__Inheritance.DogClasses;

namespace Abstraction_and__Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            int h;
            int l;
            int w;
            char r = 'y';
            string c = "";
            string n = "";
            List<Dogs> myDogs = new List<Dogs>();
            Random rand = new Random();
            while (r == 'y' || r == 'Y')
            {
                Console.WriteLine("Choose your dog!");
                Console.Write("Do you want a normal dog or a meme?:");
                char a = Console.ReadLine()[0];
                if (a == 'n' || a == 'N')
                {

                    t = rand.Next(1, 5);
                    Dogs Mine = new waterDog(h = rand.Next(12, 28), l = rand.Next(12, 48), true, "", 0);
                    if (t == 1)
                    {
                        Console.WriteLine("You got a Water Dog. A normal type");
                        Console.Write("What would you like to name it?: ");
                        n = Console.ReadLine();
                        Mine = new waterDog(h = rand.Next(12, 28), l = rand.Next(12, 48), true, n, 0);
                        myDogs.Add(Mine);
                        Console.WriteLine("You got a Water Dog named " + n + " A real type");
                        myDogs.Add(Mine);
                    }
                    else if (t == 2)
                    {
                        Console.WriteLine("You got a Forest Puppy. A normal type");
                        Console.Write("What would you like to name it?: ");
                        n = Console.ReadLine();
                        Mine = new ForestPuppy(h = rand.Next(31, 60), l = rand.Next(47, 87), true, n, 0);
                        myDogs.Add(Mine);
                    }
                    else if (t == 3)
                    {
                        int b = rand.Next(1, 6);
                        if (b == 1)
                        {
                            c = "silver";
                        }
                        else if (b == 2)
                        {
                            c = "white";
                        }
                        else if (b == 3)
                        {
                            c = "brown";
                        }
                        else if (b == 4)
                        {
                            c = "tan";
                        }
                        else if (b == 5)
                        {
                            c = "black";
                        }

                        Console.WriteLine("You got a Woofer. A normal type");
                        Console.Write("What would you like to name it?: ");
                        n = Console.ReadLine();
                        Mine = new Woofer(h = rand.Next(18, 31), l = rand.Next(20, 33), rand.Next(5, 11), rand.Next(5, 11), n, rand.Next(0, 13));
                        Console.WriteLine("You got a Woofer named " + n + ". A real type");
                        myDogs.Add(Mine);
                    }
                    if (t == 4)
                    {
                        bool s = true;
                        int v = rand.Next(1, 3);
                        if (a == 1)
                        {
                            s = false;
                        }
                        else
                        {
                            s = true;
                        }
                        Console.WriteLine("You got a Yipper. A normal type");
                        Console.Write("What would you like to name it?: ");
                        n = Console.ReadLine();
                        Mine = new Yipper(h = rand.Next(20, 25), l = rand.Next(23, 28), rand.Next(5, 11), rand.Next(0, 5), n, s, rand.Next(0, 15));
                        myDogs.Add(Mine);
                        Console.WriteLine("You got a Yipper named " + n + ". A real type");
                    }


                    Mine.statement();
                }
                else if (a == 'm' || a == 'M')
                {
                    t = rand.Next(1, 3);
                    Dogs Mine = new Doge(h = rand.Next(11, 16), l = rand.Next(13, 18), w = rand.Next(3, 7));
                    if (t == 1)
                    {
                        Mine = new Doge(h = rand.Next(11, 16), l = rand.Next(13, 18), w = rand.Next(3, 7));
                        myDogs.Add(Mine);
                        Console.WriteLine("You got a Doge! A meme type!");
                    }
                    if (t == 2)
                    {
                        Mine = new MoonMoon(rand.Next(20, 25), rand.Next(23, 28), rand.Next(5, 10));
                        myDogs.Add(Mine);
                        Console.WriteLine("You got a Moon Moon! A meme type!");
                    }

                    Mine.statement();
                }
                Console.WriteLine("Your dogs are: ");
                foreach (Dogs d in myDogs)
                {

                    Console.WriteLine(d);
                }
                Console.Write("Would you like another dog?(Y/N): ");
                r = Console.ReadLine()[0];
            }
        }
    }
}
