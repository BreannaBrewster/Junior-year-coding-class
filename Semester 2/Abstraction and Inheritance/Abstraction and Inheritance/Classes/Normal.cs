﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and_Inheritance.Classes
{
    abstract class Normal : Dogs
    {
        protected float volume;
        protected string location;
        protected bool isFriendly;
        public Normal(float height, float length, string color, float volume, string location, bool isFriendly)
            : base(height, length, color)
        {
            this.location = location;
            this.volume = volume;
            this.isFriendly = isFriendly;
        }
    }
}
