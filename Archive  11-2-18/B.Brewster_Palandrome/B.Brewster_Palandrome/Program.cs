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
            char[] punctuation = { ' ', ',', '.', '*', '-', '_', '/', '\\', ':', ';', '"', '{', '}', '[', ']', '+', '=', '!', '@', '#', '%', '&', '(', ')' };
            char r;
            string HEH = WOW.ToLower();
            string MEH = new string(punctuation.Where(c => !char.IsPunctuation(c)).ToArray());
            HEH = HEH.Replace(MEH, "");
            string MOM = new string(HEH.Reverse().ToArray());
            if (HEH == MOM)
            {
                Console.WriteLine(WOW + " is a palandrome!");
            }
            else
            {
                Console.WriteLine(WOW + " is not a palandrome");
            }
            Console.ReadKey();

        }
    }
}