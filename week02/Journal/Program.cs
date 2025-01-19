using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("1. Create New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4.Load the journal from a file");
            Console.WriteLine("5.Quit");

            Console.Write("Enter your selection: ");
            string userInput = Console.ReadLine();

            Console.WriteLine($"User Selected: {userInput}");

        }
    }
}