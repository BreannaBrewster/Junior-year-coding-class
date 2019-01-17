using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and_Inheritance.Classes
{
    class waterDog : Normal
    {
        public waterDog(float volume, string location, bool isFluffy, float height, float length, float pitch, string color, string name, bool isFriendly)
            : base(height, length, color, volume, location, isFriendly)
        {
            isFriendly = false;
            color = "grey";
            location = "beach";
            name = "seal";
            length = rand.Next(60, 240) / 12;
            height = rand.Next(12, 48) / 12;
            volume = 0;
            pitch = 5;
        }
        public override void statement()
        {
            Console.WriteLine("hello land dog, I am water dog");
        }
    }
}
