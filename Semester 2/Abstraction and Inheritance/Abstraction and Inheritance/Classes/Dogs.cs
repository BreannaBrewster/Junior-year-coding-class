using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and_Inheritance
{
    abstract class Dogs
    {
        protected Random rand = new Random();
        protected float height;
        protected string color;
        protected float length;

        public Dogs(float height, float length, string color)
        {
            this.height = height;
            this.length = length;
            this.color = color;
        }
        public abstract void statement();
    }
}
