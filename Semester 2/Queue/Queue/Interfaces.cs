using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    interface IEmptyable
    {
        void Empty();
    }
    interface ICountable
    {
        void Count();
        int CompareTo<T>(T t) where T : ICountable;
    }
    interface IPrintable
    {
        void Print();
    }

}
