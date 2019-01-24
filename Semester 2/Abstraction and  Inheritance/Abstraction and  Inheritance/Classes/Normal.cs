using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    abstract class Normal : Dogs
    {
        protected float volume;
        protected string location;
        protected bool isFriendly;
        protected string species;
        protected string name;
        public Normal(string name)
            : base()
        {
            this.name = name;
        }
    }
}
