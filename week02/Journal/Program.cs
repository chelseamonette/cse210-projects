using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();

        while(true)
        {
            Console.WriteLine("1. Create New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4.Load the journal from a file");
            Console.WriteLine("5.Quit");

            Console.Write("Enter your selection: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                journal.CreateNewEntry(); 
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Display Journal");
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Save the journal to a file");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Load the journal from a file");
            }
            else if (userInput == "5")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please try again");
            }

        }
    }
}