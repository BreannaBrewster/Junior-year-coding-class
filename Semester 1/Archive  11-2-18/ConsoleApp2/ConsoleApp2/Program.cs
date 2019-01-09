using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> myIntList = new List<int>();

            //can't use .Count, because .Count righht now is 0
            for (int i = 0; i < 11; i++)
            {
                myIntList.Add(i);
                Console.WriteLine(myIntList[i] = rand.Next(1, 10));
                Console.ReadKey();
            }
        }
    }
}
