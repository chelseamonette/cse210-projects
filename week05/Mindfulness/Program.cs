using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        
        while(true){
        // Have a menu system to allow the user to choose an activity.
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t 1. Start a breathing activity.");
            Console.WriteLine("\t 2. Start a reflecting activity.");
            Console.WriteLine("\t 3. Start listing activity.");
            Console.WriteLine("\t 4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            // Breathing Activity
            if (userChoice == "1"){
                BreathingActivity breathingActivity = new("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();



            }
            // Reflecting Activity
            else if (userChoice == "2"){


            }
            // Listing Activity
            else if (userChoice == "3"){

            }
            
        }
        
    }
}