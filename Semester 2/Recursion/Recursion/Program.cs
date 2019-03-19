using System;
using System.Collections.Generic;
namespace Recursion
{
    class Program
    {
        static Random rand = new Random(1234);
        static void Main(string[] args)
        {
            //Console.WriteLine(CheckForPrime(27));
            List<int> integers = new List<int>();
            for(int i=0; i<1000; i++)
            {
                integers.Add(rand.Next(0, 1000));
            }
            integers.Sort();
            bool result = SearchIntList(integers, 0);
            Console.WriteLine(result);
        }
        static bool CheckForPrime(int n, int divisior=2)
        {
            if(n%divisior==0)
            {
                return false;
            }
            else if (divisior == n-1)
            {
                return true;
            }
            else
            {
                return CheckForPrime(n,divisior+1);
            }
        }
        public static bool SearchIntList(List<int> integers, int n)
        {
            return SearchIntListRecursive(integers, n, 0, integers.Count - 1);
        }
        private static bool SearchIntListRecursive(List<int> integers, int n, int lowerBound, int upperBound)
        {
            if(lowerBound == upperBound )
            {
                return false;
            }
            int midPoint = (lowerBound + upperBound) / 2;
            if(integers[midPoint] == n)
            {
                return true;
            }
            if (upperBound - lowerBound == 1)
            {
                return false;
            }
            if (integers[midPoint] > n)
            {
                return SearchIntListRecursive(integers, n, lowerBound, midPoint);
            }
            if (integers[midPoint] < n)
            {
                return SearchIntListRecursive(integers, n, midPoint, upperBound);
            }
            return false;
        }

    }
}
