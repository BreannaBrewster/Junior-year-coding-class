using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and_Inheritance.Classes
{
    class MoonMoon : Meme
    {
        public MoonMoon(string color, string tag, float height, float length, float stupidity)
            : base(height, color, length, tag, stupidity)
        {
            stupidity = rand.Next(5, 10);
            color = "grey/black";
            tag = "MoonMoon";
        }
        public override void statement()
        {
            Console.WriteLine("Damn it MoonMoon");
        }
    }
}
