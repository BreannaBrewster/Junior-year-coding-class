﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    class MoonMoon : Meme
    {
        public MoonMoon()
            : base()
        {
            stupidity = rand.Next(5, 10);
            color = "grey/black/white";
            tag = "MoonMoon";
            height = rand.Next(20, 25);
            length = rand.Next(23, 28);
        }
        public override void statement()
        {
            Console.WriteLine("Damn it Moon Moon");
            Console.WriteLine("******************************");
        }
    }
}
