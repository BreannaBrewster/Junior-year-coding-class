﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    class Woofer : Doggo
    {
        string c;
        public Woofer(string name)
            : base(name)
        {

            int a = rand.Next(1, 3);
            if (a == 1)
            {
                isFriendly = false;
            }
            else
            {
                isFriendly = true;
            }
            isFluffy = true;

            pitch = rand.Next(0, 4);
            volume = rand.Next(5, 11);
            int b = rand.Next(1, 6);
            if (b == 1)
            {
                color = s[0];
            }
            else if (b == 2)
            {
                color = s[1];
            }
            else if (b == 3)
            {
                color = s[2];
            }
            else if (b == 4)
            {
                color = s[3];
            }
            else if (b == 5)
            {
                color = s[4];
            }
            location = "urban";
            name = "Woofer";
            length = rand.Next(20, 33) / 12;
            height = rand.Next(18, 31) / 12;
            age = rand.Next(0, 13);
            if (isFriendly == true)
            {
                c = "happily and wags his tail";
            }
            else
            {
                c = "angerly and growls";
            }
        }

        public override void statement()
        {
            Console.WriteLine("*" + name + " barks " + c + "*");
        }

    }
}
