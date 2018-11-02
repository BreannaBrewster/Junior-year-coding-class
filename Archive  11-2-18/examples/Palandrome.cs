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
            Console.WriteLine("What is your sentence?");
            string WOW = Console.ReadLine();
            String[] punctuation = { " ", ",", ".","*","-", "_", "/" };
            string HEH = WOW.ToLower();
            string HEH = HEH.Replace(punctuation, "");
            string MOM = new string(HEH.Reverse().ToArray());

            Console.WriteLine("Reverse Reverse");
            Console.WriteLine(MOM);
            //Console.ReadKey();
            if(HEH == MOM)
            {
                Console.WriteLine(WOW + " is a palandrome!");
            }
            Console.ReadKey();

            }
        }
    }
}



