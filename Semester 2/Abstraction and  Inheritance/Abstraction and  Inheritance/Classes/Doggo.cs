using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    abstract class Doggo : Normal
    {
        protected bool isFluffy;
        protected float pitch;
        protected float age;
        protected string[] s = new string[5] { "white", "brown", "tan", "black", "silver" };
        public Doggo(float height, float length, string color, float volume, string location, bool isFluffy, bool isFriendly, float pitch, string name, float age)
            : base(height, length, color, volume, location, isFriendly, name)
        {
            this.isFriendly = isFriendly;
            this.pitch = pitch;
            this.age = age;

        }
    }
}
