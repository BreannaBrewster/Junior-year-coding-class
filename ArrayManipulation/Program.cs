using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int seed = 1234;
            Random rand = new Random(seed);

            //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }


            int temp = array[0];
            array[0] = array[1];
            array[1] = temp;

            //The following can be used to test your implementations. Uncomment each line as you go to test.
            //NOTE: You don't have to do each line sequentially. For example, implementing the FindMin and FindMax methods
            //will be very useful for your FindRange method. Hint... Hint...

            Console.WriteLine("UNSORTED: ");
            PrintArray(array);
            Console.WriteLine("BUBBLE SORTED: ");
            PrintArray(BubbleSort(array));
            Console.WriteLine("SELECTION SORTED: ");
            PrintArray(SelectionSort(array));
            Console.WriteLine("MEAN: " + FindMean(array));
            Console.WriteLine("MEDIAN: " + FindMedian(SelectionSort(array)));
            Console.WriteLine("RANGE: " + FindRange(array));
            Console.WriteLine("MODE: " + FindMode(array));
            Console.WriteLine("MAX: " + FindMax(array));
            Console.WriteLine("MIN: " + FindMin(array));
        }

        /// <summary>
        /// Prints the array in | x | y | z | a | b | c | format
        /// </summary>
        /// <param name="array">The array to be printed</param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("| " + array[i] + " ");
            }
            Console.WriteLine("|");
        }

        /// <summary>
        /// Implements a bubble sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] BubbleSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            for(int i=0; i<mutatedArray.Length; i++)
            {
                for (int j =0; j < mutatedArray.Length; j++)
                {
                    if (mutatedArray[i] < mutatedArray[j])
                    {
                        int k = mutatedArray[i];
                        mutatedArray[i] = mutatedArray[j];
                        mutatedArray[j] = k;
                    }
                }
            }
            return mutatedArray;
        }

        /// <summary>
        /// Implements a selection sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] SelectionSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            for (int i = 0; i < mutatedArray.Length-1; i++)
            {
                int k = i;
                for (int j = i; j < mutatedArray.Length; j++)
                {
                    if (mutatedArray[j] < mutatedArray[k])
                    {
                        k = j;
                    }
                }
                if (k != i)
                {
                    int h = mutatedArray[i];
                    mutatedArray[i] = mutatedArray[k];
                    mutatedArray[k] = h;
                }
            }
            return mutatedArray;
        } 

        /// <summary>
        /// Finds the mean (average) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mean</returns>
        public static float FindMean(int[] array)
        {
            float mean =0;
            for(int i=0; i<array.Length; i++)
            {
                mean += array[i];
            }
            mean = mean / array.Length;
            return mean;
        }

        /// <summary>
        /// Finds the median (middle element of sorted array) of the array
        /// In the case that the array is an even length, average the two middle elements
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The median</returns>
        public static float FindMedian(int[] array)
        {
            SelectionSort(array);
            float median;
            int i = SelectionSort(array).Length / 2;
            float q = SelectionSort(array).Length / 2;
            if (i != q)
            {
                median = SelectionSort(array)[i];

            }
            else
            {
                median = (SelectionSort(array)[i] + SelectionSort(array)[i - 1]) / 2f;

            }
            return median;
        }

        /// <summary>
        /// Finds the range (highest value - lowest value) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The range</returns>
        public static int FindRange(int[] array)
        {
            int h = SelectionSort(array)[array.Length-1];
            int l = SelectionSort(array)[0];
            int range = h - l;
            return range;
        }

        /// <summary>
        /// Finds the mode (most common occuring element) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mode</returns>
        public static int FindMode(int[] array)
        {
            int n = 0;
            int mode = 0;
            int count=0;
            for(int i=0; i<array.Length; i++)
            {
                for (int j = i++; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        count++;
                    }
                    if(count > n)
                    {
                        n = count;
                        mode = array[i];
                    }
                }
            }
            return mode;
        }

        /// <summary>
        /// Finds the maximum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The maximum value</returns>
        public static int FindMax(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                max = array[i];
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[max] < array[j])
                    {
                        max = j;
                        
                    }
                }
            }
            max = array[max];
            return max ;
        }

        /// <summary>
        /// Finds the minimum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The minimum value</returns>
        public static int FindMin(int[] array)
        {
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                min = array[i];
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }
            }
            min = array[min];
            return min;
        }
    }
}
