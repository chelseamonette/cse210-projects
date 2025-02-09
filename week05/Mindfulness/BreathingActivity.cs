// Added creativity to this class by giving extra options to choose from in types of breathing.

using System;
public class BreathingActivity : Activity{
    private string _userChoice;
    public BreathingActivity(string name, string description) : base(name, description){

    }
    public void Run(){
        // Display start message
        DisplayStartingMessage();
        _userChoice = UserChoice();

        DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

        if (_userChoice == "1"){
        // Start the breathing exercise
            while(DateTime.Now < endTime){
                Console.Write("Breathe in... ");
                ShowCountDown(4);
                Console.WriteLine();
                Console.Write("Hold your breath... ");
                ShowCountDown(7);
                Console.WriteLine();
                Console.Write("Now breathe out... ");
                ShowCountDown(8);
                Console.WriteLine();
            }
        }
        else if (_userChoice == "2"){
            while(DateTime.Now < endTime){
                Console.Write("Inhale... ");
                ShowCountDown(4);
                Console.Write("Hold... ");
                ShowCountDown(4);
                Console.Write("Exhale... ");
                ShowCountDown(4);
                Console.Write("Hold... ");
                ShowCountDown(4);
            }
        }
        else if (_userChoice == "3"){
            while(DateTime.Now < endTime){
                Console.Write("Inhale... ");
                ShowCountDown(6);
                Console.Write("Exhale... ");
                ShowCountDown(2);
            }
        }
        DisplayEndingMessage();

    }

    public string UserChoice(){
        Console.WriteLine("Select a type of breathing excercise would you like to complete today:");
        Console.WriteLine("1. Calming.");
        Console.WriteLine("2. Box");
        Console.WriteLine("3. Awake");
        Console.Write("Select from the list: ");
        _userChoice = Console.ReadLine();
        Console.Clear();
        return _userChoice;
    }
}