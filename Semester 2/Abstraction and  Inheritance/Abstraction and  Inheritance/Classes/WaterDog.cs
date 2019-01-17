using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    class waterDog : Normal
    {
        public waterDog(float volume, string location, float height, float length, string color, string name, bool isFriendly)
            : base(height,length, color,volume, location, isFriendly, name)
        {
            isFriendly = true;
            color = "grey";
            location = "beach";
            name = "seal";
            length = rand.Next(60, 240) / 12;
            height = rand.Next(12, 48) / 12;
            volume = 0;
        }
        public override void statement()
        {
            Console.WriteLine("Hello land dog, I am water dog");
        }
    }
}
