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
                ReflectingActivity reflectingActivity = new("Relfecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.Run();

            }
            // Listing Activity
            else if (userChoice == "3"){

            }
            else{
                break;
            }
            
        }
        
    }
}