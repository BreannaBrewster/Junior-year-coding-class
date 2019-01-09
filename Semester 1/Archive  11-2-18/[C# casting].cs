using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] alpha = new char[26];
            alpha[0] = 'a';
            alpha[1] = 'b';
            alpha[2] = 'c';
            alpha[3] = 'd';
            alpha[4] = 'e';
            alpha[5] = 'f';
            alpha[6] = 'g';
            alpha[7] = 'h';
            alpha[8] = 'i';
            alpha[9] = 'j';
            alpha[10] = 'k';
            alpha[11] = 'l';
            alpha[12] = 'm';
            alpha[13] = 'n';
            alpha[14] = 'o';
            alpha[15] = 'p';
            alpha[16] = 'q';
            alpha[17] = 'r';
            alpha[18] = 's';
            alpha[19] = 't';
            alpha[20] = 'u';
            alpha[21] = 'v';
            alpha[22] = 'w';
            alpha[23] = 'x';
            alpha[24] = 'y';
            alpha[25] = 'z';

            for (int i = 0; i< alpha.Length; i++)
            {
                char mychar = alpha[i];
                int myint = mychar;
                Console.WriteLine(mychar + " = " + myint);
            }

            for(int i = 0; i<= 13000; i++)
            {
                char myChar = (char)i;
                Console.Write(myChar);
            }
        }
    }
}
