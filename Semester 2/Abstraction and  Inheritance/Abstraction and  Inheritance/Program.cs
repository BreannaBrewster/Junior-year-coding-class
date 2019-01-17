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
            string f = "";
            List<Dogs> myDogs = new List<Dogs>();
            Random rand = new Random();
            while (r == 'y' || r == 'Y')
            {
                Console.WriteLine("Choose your dog!");
                Console.Write("Do you want a normal dog or a meme?:");
                char a = Console.ReadLine()[0];
                if (a == 'n' || a == 'N')
                {
                    t = rand.Next(1, 6);
                    Dogs Mine = new waterDog(0,  "beach", l = rand.Next(12, 48), h = rand.Next(12, 28), c= "grey", f = "seal", true);
                    if (t == 1)
                    {
                        Mine = new waterDog(0, "beach", l = rand.Next(12, 48), h = rand.Next(12, 28), c = "grey", f = "Water Dog (seal)", true);
                        myDogs.Add(Mine);
                    }
                    else if (t == 2)
                    {
                        Mine = new ForestPuppy(h = rand.Next(31, 60), l = rand.Next(47, 87), 0, c = "grey", "beach", f = "Forest Puppy(deer)", true);
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

                        Mine = new Woofer(h= rand.Next(18, 31), l= rand.Next(20, 33), rand.Next(5, 11), rand.Next(5, 11), c, "Urban", "Woofer (Dog)", true, true, rand.Next(0, 13));
                        myDogs.Add(Mine);
                    }
                    if (t == 4)
                    {
                        Mine = new Yipper("grey/black/white", "MoonMoon", rand.Next(20, 25), rand.Next(23, 28), rand.Next(5, 10));
                        myDogs.Add(Mine);
                    }

                    Console.WriteLine("You got a " + f + "Real type");
                    Mine.statement();
                }
                else if (a == 'm' || a == 'M')
                {
                    t = rand.Next(1, 3);
                    Dogs Mine = new Doge(h = rand.Next(11, 16), l = rand.Next(13, 18), c = "tan", f = "Doge", w = rand.Next(3, 7)); ;
                    if (t == 1)
                    {
                        Mine = new Doge(h = rand.Next(11, 16), l = rand.Next(13, 18), c = "tan", f = "Doge", w = rand.Next(3, 7));
                        myDogs.Add(Mine);
                    }
                    if (t == 2)
                    {
                        Mine = new MoonMoon("grey/black/white", "MoonMoon", rand.Next(20, 25), rand.Next(23, 28), rand.Next(5, 10));
                        myDogs.Add(Mine);
                    }
                    Console.WriteLine("You got a " + f + "A meme type!");
                    Mine.statement();
                }
                Console.Write("Would you like another dog?(Y/N): ");
                r = Console.ReadLine()[0];
            }
        }
    }
}
