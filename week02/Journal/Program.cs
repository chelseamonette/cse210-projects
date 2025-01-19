using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables
        Journal journal = new();

        // Give user a menu
        while(true)
        {
            Console.WriteLine("1. Create New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your selection: ");
            string userInput = Console.ReadLine();

            // Create New Entry
            if (userInput == "1")
            {
                journal.CreateNewEntry(); 
            }

            // Display Journal
            else if (userInput == "2")
            {
                Console.WriteLine("Display Journal");
            }

            // Save the Journal
            else if (userInput == "3")
            {
                Console.WriteLine("Save the journal to a file");
            }

            // Load a Journal
            else if (userInput == "4")
            {
                Console.WriteLine("Load the journal from a file");
            }

            // Quit
            else if (userInput == "5")
            {
                return;
            }

            // Invalid selection
            else
            {
                Console.WriteLine("Please try again");
            }

        }
    }
}