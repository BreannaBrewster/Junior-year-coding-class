using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and_Inheritance.Classes
{
    class ForestPuppy : Normal
    {
        Random rand = new Random();
        int a;
        public ForestPuppy(float height, float length, float volume, float pitch, string color, string location, string name, bool isFluffy, bool isFriendly)
            : base(height, length, color, volume, location, isFriendly)
        {
            isFriendly = true;
            isFluffy = false;
            color = "grey";
            location = "beach";
            name = "deer";
            length = rand.Next(60, 240) / 12;
            height = rand.Next(12, 48) / 12;
            volume = 0;
            pitch = 5;
        }
        public override void statement()
        {
            Console.WriteLine("...");
        }
    }
}
