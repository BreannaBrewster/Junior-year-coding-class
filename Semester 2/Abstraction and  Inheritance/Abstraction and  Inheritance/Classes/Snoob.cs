using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    class Snoob : Meme
    {
        public Snoob()
            : base()
        {
            stupidity = rand.Next(0, 7);
            color = "white";
            tag = "Snoob";
            height = rand.Next(19, 25);
            length = rand.Next(21, 28);
        }
        public override void statement()
        {
            Console.WriteLine("The shoob is a breed of heckin low flying clouds");
            Console.WriteLine("******************************");
        }
    }
}
