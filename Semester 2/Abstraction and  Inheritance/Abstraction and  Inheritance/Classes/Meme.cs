using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    abstract class Meme : Dogs
    {
        protected string tag;
        protected bool isPopular;
        protected float stupidity;

        public Meme()
            : base()
        {
            isPopular = true;

        }
    }
}
