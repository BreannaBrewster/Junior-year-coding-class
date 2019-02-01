using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue<T> : IEmptyable, IPrintable, ICountable where T : ICountable
    {
        int b;
        List<T> hold = new List<T>();

        public void EnQueue(T val)
        {
            hold.Insert(0, val);
        }
        public T DeQueue()
        {
            T temp= hold[hold.Count - 1];
            if (hold.Count < 2)
            {
                Console.WriteLine("There is" + hold.Count + " element in this stack. Are you sure you want to delete this stack? (Y/N)");
                string x = Console.ReadLine().ToUpper();
                if (x[0] == 'Y' || x[0] == 'y')
                {
                    List<int> hold = new List<int>();
                }
            }
            else
            {
                temp = hold[hold.Count - 1];
                hold.RemoveAt(hold.Count -1);
                Console.WriteLine(b);
            }
            return temp;
        }
        public T peek()
        {
            if (hold.Count < 1)
            {
                Console.WriteLine("This queue is empty");
            }
            return hold[hold.Count-1];
        }
        public void print()
        {
            foreach (T i in hold)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
        public T Search(T a) 
        {
            int c = -1;
            int d = 0;
            List<int> l = new List<int>();
            Console.WriteLine("The value " + a + " is located at the position(s): ");
            for (int i=0;i<hold.Count; i++)
            {
                if(a.CompareTo(hold[i]) == 0)
                {
                    l.Add(i);
                }
            }
            return default(T);
        }

        public void Print()
        {
            foreach(T t in hold)
            {
                Console.WriteLine(t);
            }
            //throw new NotImplementedException();
        }

        public void Count()
        {
            throw new NotImplementedException();
        }

        public void Empty()
        {
            throw new NotImplementedException();
        }

        public int CompareTo<T1>(T1 t) where T1 : ICountable
        {
            throw new NotImplementedException();
        }
    }
}

