using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and_Inheritance.Classes
{
    abstract class Meme : Dogs
    {
        protected string tag;
        protected bool isPopular;
        protected float stupidity;

        public Meme(float height,string color, float length, string tag, float stupidity)
            : base(height, length, color)
        {
            isPopular = true;
            this.tag= tag;
            this.stupidity = stupidity;
        }
    }
}
