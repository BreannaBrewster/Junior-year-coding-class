using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and_Inheritance.Classes
{
    abstract class Doggo:Normal
    {
        protected bool isFluffy;
        //protected bool isFriendly;
        protected float pitch;
        protected string name;
        protected string[] s = new string[5] { "white", "brown", "tan", "black", "silver" };
        public Doggo(float height, float length, string color, float volume, string location, bool isFluffy, bool isFriendly, float pitch, string name)
            : base(volume,location, isFriendly)
        {
            this.isFriendly = isFriendly;
            this.pitch = pitch;
            this.name = name;

        }
    }
}
