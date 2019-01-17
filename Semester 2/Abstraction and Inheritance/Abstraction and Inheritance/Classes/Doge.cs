using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and_Inheritance.Classes
{
    class Doge : Meme
        {
            public Doge(float height, float length, string color, string tag, float stupidity)
            : base(height, color, length, tag, stupidity)
        {
            length = rand.Next(13, 18);
            height = length-2;
            color = "tan";
            tag = "Doge";
            stupidity = rand.Next(5, 10);

        }
        public override void statement()
        {
            Console.WriteLine("Much wow");
        }
    }
}
