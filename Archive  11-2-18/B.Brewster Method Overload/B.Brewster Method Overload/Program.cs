using System;

namespace B.Brewster_Method_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 7, 6, 9, 0 };
            Print(5);
            Print(new int[] {1,7,6,9,0 }, new int[2, 4]);
            Print(Math.PI,2);
            Print(3, new int[] { 1, 7, 6, 9, 0 }, new int[3][]);
        }
        static void Print(int[] array)
        {
            Console.Write("| " + array.Length + " ");
        }
        static void Print(int a)
        {
            Console.WriteLine("Integer " + a);
        }
        static void Print(int[] c, int[,] array)
        {
            int q = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(c[i] + " | ");
                }
                Console.WriteLine();
            }
        }
        static void Print(int a,int[] b, int[][] array)
        {
            int q = 0;
            array = new int[a][];
            
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                     Console.Write(b[q++] + " | ");
                }
                Console.WriteLine();
            }
        }
        static void Print(double f, int n)
        {
            string t = new string("0.");
            for(int i=0; i<n; i++)
            {
                t = t + '#';
            }
            string printVal = f.ToString(t);//f.ToString("0.##");
            Console.WriteLine(printVal);
        }
    }
}
