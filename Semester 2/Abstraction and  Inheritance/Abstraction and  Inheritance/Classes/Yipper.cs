﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_and__Inheritance.DogClasses
{
    class Yipper : Doggo
    {
        string c;
        public Yipper(string name)
            : base(name)
        {
            int a = rand.Next(1, 3);
            if (a == 1)
            {
            isFriendly = false;
            isFluffy = false;
            }
            else
            {
                isFriendly = true;
                isFluffy = true;
            }
            pitch = rand.Next(7, 11);
            volume = rand.Next(5, 11);
            age = rand.Next(0, 15);
            int b = rand.Next(1, 6);
            if (b == 1)
            {
                color = s[0];
            }
            if (b == 2)
            {
                color = s[1];
            }
            if (b == 3)
            {
                color = s[2];
            }
            if (b == 4)
            {
                color = s[3];
            }
            if (b == 5)
            {
                color = s[4];
            }
            location = "urban";
            name = "Dog";
            //length = rand.Next(6, 17) / 12;
            //height = rand.Next(8, 18) / 12;
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
            Console.WriteLine("*" + name + "barks " + c + "*");

        }
    }
}
