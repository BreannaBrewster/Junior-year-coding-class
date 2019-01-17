﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    class Doge : Meme
    {
        public Doge(float height, float length, string color, string tag, float stupidity)
        : base(height, color, length, tag, stupidity)
        {
            length = rand.Next(13, 18);
            height = rand.Next(11, 16);
            color = "tan";
            tag = "Doge";
            stupidity = rand.Next(3, 7);

        }
        public override void statement()
        {
            Console.WriteLine("Much wow");
        }
    }
}
