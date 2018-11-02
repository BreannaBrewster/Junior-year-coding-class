using System;

namespace B.Brewster_2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiDimensionalArray = new int[10, 5];
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    multiDimensionalArray[i, j] = i * j;
                }

            }
            printArray(multiDimensionalArray);
            int[][] jaggedArray = new int[10][];
            for(int i=0; i <jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = new int[i+1];
                for(int j=0; j<jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i * j;
                }
            }
            printJaggedArray(jaggedArray);
        }
        static void printArray(int[,] multiDimensionalArray)
        { 
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    if (multiDimensionalArray[i, j] > 9)
                    {
                        Console.Write(multiDimensionalArray[i, j] + " | ");
                    }
                    else
                    {
                        Console.Write(" " + multiDimensionalArray[i, j] + " | ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void printJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] > 9)
                    {
                        Console.Write((jaggedArray[i][j] =i*j) + " | ");
                    }
                    else
                    {
                        Console.Write((jaggedArray[i][j] = i * j) + " | ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
