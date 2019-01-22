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
        public Doggo(float height, float length, float volume, float pitch, string name, float age)
            : base(height, length, name, volume)
        {
            this.pitch = pitch;
            this.age = age;

        }
    }
}
