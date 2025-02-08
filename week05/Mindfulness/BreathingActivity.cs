using System;
public class BreathingActivity : Activity{
    public BreathingActivity(string name, string description) : base(name, description){

    }
    public void Run(){
        // Display start message
        DisplayStartingMessage();
        // Start the breathing exercise
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
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
        DisplayEndingMessage();

    }
}