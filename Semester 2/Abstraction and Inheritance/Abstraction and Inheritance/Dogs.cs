using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and_Inheritance
{
    abstract class Dogs
    {
        protected float height;
        protected string color;
        protected float length;

        public Dogs(float height, float length, string color)
        {
            this.height = height;
            this.color = color;
        }
        abstract class Meme
        {
            protected string tag;
            protected bool isPopular;
            protected float stupidity;

            public Meme(string tag, float stupidity)
            {
                this.tag = tag;
                this.stupidity = stupidity;
            }
            class Doge : Meme
            {
                public Doge(string color, string tag, float height, float length,  float stupidity)
                    : base(tag, stupidity)
                { 
                    isPopular = true;
                }
            }
            class MoonMoon : Meme
            {
                public MoonMoon(string color, string tag, float height, float length, float stupidity)
                    : base(tag, stupidity)
                {
                    isPopular = true;
                }

            }
        }
        abstract class Normal
        { 
            protected float volume;
            protected float pitch;
            protected bool isFluffy;
            public Normal(float volume, float pitch)
            {
                this.volume = volume;
                this.pitch = pitch;
            }
            abstract class Doggo
            {
                protected bool isFriendly;
                protected string location;
                protected string name;
                public Doggo(string location, string name)
                {
                    this.location = location;
                    this.name = name;
                }
                class Woofer : Doggo
                {
                    public Woofer(float height, float length, float volume, float pitch, string color, string location, string name)
                        : base(location, name)
                    {
                        Random rand = new Random();
                        pitch = rand.Next(0, 4);
                        isFriendly = true;
                        location = "urban";
                    }
                }
                class Yipper : Doggo
                {
                    public Yipper(float height, float length, float volume, float pitch, string color, string location, string name)
                        : base(location, name)
                    {
                        Random rand = new Random();
                        pitch = rand.Next(7, 11);
                        isFriendly = true;
                        location = "urban";
                    }
                }
                class forestPuppy : Doggo
                {
                    public forestPuppy(float height, float length, float volume, float pitch, string color, string location, string name)
                        : base(location, name)
                    {
                        isFriendly = true;
                        location = "forest";
                        volume = 0;
                        pitch = 5;
                    }
                }
                class waterDog : Doggo
                {
                    public waterDog(float height, float length, float volume, float pitch, string color, string location, string name)
                        : base(location, name)
                    {
                        isFriendly = true;
                        location = "beach";
                        volume = 0;
                        pitch = 5;
                    }
                }

            }
        }
       
    }
}
