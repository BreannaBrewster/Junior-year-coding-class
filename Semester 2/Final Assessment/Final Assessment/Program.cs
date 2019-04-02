using System;

namespace Final_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            while (userInput != 9)
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Please enter an integer value for the action you want to perform.");
                Console.WriteLine("1. Print Hello World");
                Console.WriteLine("2. Add two whole numbers together");
                Console.WriteLine("3. Calulcate the area of a circle");
                Console.WriteLine("4. Calculate the area of a triangle");
                Console.WriteLine("5. Draw a square");
                Console.WriteLine("6. Draw a hollow square");
                Console.WriteLine("7. Swap integer variables");
                Console.WriteLine("8. Reverse a string");
                Console.WriteLine("9. End the program");
                Console.WriteLine("------------------------------------------------------------------");
                userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Hello World");
                        break;
                    case 2:
                        Console.Write("Please enter the first integer value you want to add: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the second integer value you want to add: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine(a + " + " + b + " = " + (a + b));
                        break;
                    case 3:
                        Console.Write("What is the radius?: ");
                        int r = int.Parse(Console.ReadLine());
                        Console.WriteLine("The area of a circle with the radius " + r + " is " + CircleArea(r));
                        break;
                    case 4:
                        Console.Write("Please enter the first side value: ");
                        int length1 = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the second side value: ");
                        int length2 = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the third side value: ");
                        int length3 = int.Parse(Console.ReadLine());
                        Console.WriteLine(TriangleArea(length1, length2, length3));
                        break;
                    case 5:
                        Console.Write("What size square do yo want to draw?: ");
                        int n = int.Parse(Console.ReadLine());
                        DrawSquare(n);
                        break;
                    case 6:
                        Console.Write("What size square do yo want to draw?: ");
                        n = int.Parse(Console.ReadLine());
                        DrawHollowSquare(n);
                        break;
                    case 7:
                        Console.Write("Please enter the first integer value you want to swap: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the second integer value you want to swap: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Swapping " + a + " and " + b);
                        SwapInt(a, b);
                        break;
                    case 8:
                        Console.Write("Please enter the string you want to reverse: ");
                        string s = Console.ReadLine();
                        char[] sArray = s.ToCharArray();
                        Array.Reverse(sArray);
                        Console.WriteLine("Original string = " + s);
                        Console.WriteLine("Reversed string = " + String.Join("",sArray));
                        
                        break;
                    case 9:
                        Console.WriteLine("Thanks for using the program.");
                        break;
                    default:
                        break;
                }
            }
        }
        static double CircleArea (int radius)
        {
            double area= Math.PI * (radius*radius);
            return area;
        }
        static double TriangleArea(int length1, int length2, int length3)
        {
            double p = (length1 + length2 + length3) / 2;
            double area = Math.Sqrt(p * (p - length1) * (p - length2) * (p - length3));
            return area;
        }
        static void DrawSquare(int n)
        {
            for (int height = 0; height < n; height++)
            {
                for (int width = 0; width < n; width++)
                {
                    Console.Write('X');
                }
                Console.WriteLine();
            }
        }
        static void DrawHollowSquare(int n)
        {
            for (int height = 0; height < n; height++)
            {
                for (int width = 0; width < n; width++)
                {
                    if (width == 0 || width == n-1 || height == 0 || height == n-1)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        static void SwapInt(int a, int b)
        { 
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swap values are " + a + " and " + b);
        }
    }
}
