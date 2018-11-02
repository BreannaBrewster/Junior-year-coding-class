using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[10];
            int[] myArray = new int[10];
            Random rand = new Random();

            for (int i = 0; i < myIntArray.Length; i++)
            {
                //myIntArray[i] = i;
                Console.WriteLine(myIntArray[i] = rand.Next(1, 10));
            }
        }
    }
}
