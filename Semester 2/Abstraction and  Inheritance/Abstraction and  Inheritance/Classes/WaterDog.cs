using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    class waterDog : Normal
    {
        public waterDog(string name)
            : base(name)
        {
            isFriendly = true;
            color = "grey";
            location = "beach";
            species = "seal";
            length = rand.Next(60, 240) / 12;
            height = rand.Next(12, 48) / 12;
            volume = 0;
        }
        public override void statement()
        {
            Console.WriteLine("Hello land dog, I am water dog");
            Console.WriteLine("******************************");
        }
    }
}
