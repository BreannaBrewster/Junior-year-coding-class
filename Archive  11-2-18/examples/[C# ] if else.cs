using System;
public class Program
{
    public static void Main(string[] args)
    {

        int age;
        Console.Write("Do you live in Colorado?:");
        string result = Console.ReadLine();
        if (result == "n")
        {
            Console.WriteLine("You can't legally consume majijuana");
        }
        else
        {
            result = result.ToString();
            Console.Write("What is your age?:");
            age = int.Parse(Console.ReadLine());

            if (result == "y" && age >= 18)
            {
                Console.WriteLine("You can legally consume majijuana");
            }
            else if (result == "y" && age >= 16)
            {
                Console.WriteLine("You can't consume majijuana, but you can drive");
            }
            else
            {
                Console.WriteLine("You can't legally consume majijuana");
            }
        }

    }
}
