using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ___LAMDA_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            ex1();
            ex2();
            //problem1();
            problem2();
        }
        static void ex1()
        {
            List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> l2 = new List<int>() { 3, 2, 2, 8, 0, 4, 7 };
            List<int> l3 = l2.Intersect(l1).ToList();
            //Same as
            //for(int i=0; i<l1.Count; i++)
            //{
            //    //if (l2.Contains(l1[i]) && !l3.Contains(l1[i]))
            //    //{
            //    //    l3.Add(l1[i]);
            //    //}
            //}
        }
        static void ex2()
        {
            List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> l2 = l1.Where(t => t % 5 == 0).ToList();
            //Same as
            //for(int i=0; i<l1.Count; i++)
            //{
            //    //if (l1[i]>= 5)
            //    //{
            //    //    l2.Add(l1[i]);
            //    //}
            //}
        }
        static void problem1()
        {
            List<int> test = new List<int>() { 10, 59, 70, 80, 42, 65 };
            List<int> quiz = new List<int>() { 86, 61, 44, 6, 86, 28, 26, 63, 75, 76 };
            List<int> homeWork = new List<int>() { 100, 80, 85, 90, 90, 85 };
            double grade = test.Average() * 0.5 + quiz.Average() * .25 + homeWork.Average() * .25;
            Console.WriteLine(grade);
            //double a=0;
            //double b=0;
            //double c=0;
            //foreach (int i in test)
            //{
            //    a = a + i;
            //}
            //a = (a / test.Count);
            //foreach(int i in quiz)
            //{
            //    b = b + i;
            //}
            //b = (b / quiz.Count);
            //foreach(int i in homeWork)
            //{
            //    c = c + i;
            //}
            //c = (c / homeWork.Count);
            //grade = a *.5 + b*.25 + c*.25;
            //Console.WriteLine(grade);
        }
        static void problem2()//sort
        {
            List<int> l1 = new List<int>() { 10, 59, 70, 80, 42, 65 };
            List<int> l2 = new List<int>() { 86, 61, 44, 6, 86, 28, 26, 63, 75, 76 };
            List<int> l3 = l1.Concat(l2).OrderBy(t => t).ToList();
            //foreach (int i in l3)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach(int i in l1)
            //{
            //    l3.Add(i);
            //}
            //foreach (int i in l2)
            //{
            //    l3.Add(i);
            //}
            //bool sort;
            //do
            //{
            //    int temp;
            //    sort = false;
            //    for (int i = 0; i < l3.Count; i++)
            //    {
            //        for (int j = 0; j < l3.Count; j++)
            //        {
            //            if (l3[i] < l3[j])
            //            {
            //                temp = l3[i];
            //                l3[i] = l3[j];
            //                l3[j] = temp;
            //                sort = true;
            //            }
            //        }
            //    }
            //} while (sort != true);
        }
    }
}
