using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    class ForestPuppy : Normal
    {
        int a;
        public ForestPuppy(string name)
            : base(name)
        {
            isFriendly = true;
            color = "brown";
            location = "forest";
            species = "deer";
            length = rand.Next(47, 87) / 12;
            height = rand.Next(31, 60) / 12;
            volume = 0;
        }
        public override void statement()
        {

        }
    }
}
