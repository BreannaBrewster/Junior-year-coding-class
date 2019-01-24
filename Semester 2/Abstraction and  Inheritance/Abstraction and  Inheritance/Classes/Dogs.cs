using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    abstract class Dogs
    {
        protected Random rand = new Random();
        protected float height;
        protected string color;
        protected float length;

        public Dogs()
        {

        }
        public abstract void statement();
    }
}
