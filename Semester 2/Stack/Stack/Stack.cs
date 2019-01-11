using System;
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
                Console.WriteLine("There is" + hold.Count + " element in this stack. Are you sure you want to delete this stack? (Y/N)");
                string x = Console.ReadLine().ToUpper();
                if(x[0] == 'Y' || x[0] == 'y')
                {
                    List<int> hold = new List<int>();
                }
            }
            else
            {
                b = hold[hold.Count - 1];
                hold.RemoveAt(hold.Count - 1);
                Console.WriteLine(b);
            }
            return b;
        }
        public int peek()
        {
            Console.Write(hold[hold.Count - 1]);
            Console.WriteLine();
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
        public int Search(int a)
        {
            int c=-1;
            int d = 0;
            Console.WriteLine("The value" + a + "is located at the position(s): ");
            foreach(int i in hold)
            {
                if (d > 1)
                {
                    Console.Write(", ");
                }
                c++;
                if(i == a)
                {
                    d++;
                    Console.Write(c);
                    
                }
            }
            return c;
        }
    }
}
