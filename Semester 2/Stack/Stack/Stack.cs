﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack
    {
        int b;
        List<int> hold = new List<int>();
        public void stack()
        {
            
        }
        public void Push(int a)
        {
            hold.Add(a);
        }
        public int Pop()
        {
            
            if(hold.Count < 2)
            {
                Console.WriteLine("There is one element in this stack. Are you sure you want to remove it (Y/N)");
                string x = Console.ReadLine().ToUpper();
                if(x[0] == 'Y')
                {
                    List<int> hold = new List<int>();
                }
            }
            else
            {
                b = hold[hold.Count - 1];
                hold.RemoveAt(hold.Count - 1);
                //Console.WriteLine(b);
            }
            return b;
        }
        public int peek()
        {
            Console.Write(hold[hold.Count - 1]);
            //Console.WriteLine();
            return b;
        }
        public void print()
        {
            foreach(int i in hold)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
    }
}
