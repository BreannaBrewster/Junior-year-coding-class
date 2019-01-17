using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    class ForestPuppy : Normal
    {
        int a;
        public ForestPuppy(float height, float length, float volume, string color, string location, string name, bool isFriendly)
            : base(height, length, color, volume, location, isFriendly, name)
        {
            isFriendly = true;
            color = "brown";
            location = "forest";
            name = "deer";
            length = rand.Next(47, 87) / 12;
            height = rand.Next(31, 60) / 12;
            volume = 0;
        }
        public override void statement()
        {
            
        }
    }
}
