using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu=1;
            Stack myStack = new Stack();
            while (menu != 0)
            {
                Console.WriteLine();
                Console.WriteLine("****************************************************");
                Console.WriteLine("press 1 to add a number to the stack");
                Console.WriteLine("press 2 to remove the top element of the stack");
                Console.WriteLine("press 3 to return the top element of the stack");
                Console.WriteLine("press 4 to print the list of element in the stack");
                Console.WriteLine("press 5 to find the position of a number in the stack");
                Console.WriteLine("press 0 to exit");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.Write("What number would you like to add to the stack?:");
                    int a = int.Parse(Console.ReadLine());
                    myStack.Push(a); 
                }
                if (menu == 2)
                {
                    myStack.Pop();
                }
                if (menu == 3)
                {
                    myStack.peek();
                }
                if (menu == 4)
                {
                    myStack.print();
                }
                if (menu == 5)
                {
                    Console.Write("What number would you like to search for?: ");
                    int a = int.Parse(Console.ReadLine());
                    myStack.Search(a);
                }
            }
        }
    }
}
