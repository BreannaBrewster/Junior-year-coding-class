using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 1;
            Queue myQueue = new Queue();
            while (menu != 0)
            {
                Console.WriteLine();
                Console.WriteLine("****************************************************");
                Console.WriteLine("press 1 to add a number to the back of the queue");
                Console.WriteLine("press 2 to remove the front element of the queue");
                Console.WriteLine("press 3 to return the front element of the queue");
                Console.WriteLine("press 4 to print the list of element in the queue");
                Console.WriteLine("press 5 to find the position of a number in the queue");
                Console.WriteLine("press 0 to exit");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.Write("What number would you like to add to the queue?:");
                    int a = int.Parse(Console.ReadLine());
                    myQueue.EnQueue(a);
                }
                if (menu == 2)
                {
                    myQueue.DeQueue();
                }
                if (menu == 3)
                {
                    myQueue.peek();
                }
                if (menu == 4)
                {
                    myQueue.print();
                }
                if (menu == 5)
                {
                    Console.Write("What number would you like to search for?: ");
                    int a = int.Parse(Console.ReadLine());
                    myQueue.Search(a);
                }
            }
        }
    }
}
