using System;
public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description){
        _name = name;
        _description = description;
        
    }
    public void DisplayStartingMessage(){
        // CLear the console and display message
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        // Blank line and description
        Console.WriteLine();
        Console.WriteLine(_description);
        // Blank line and prompt for duration
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for you session? ");
        // Convert input into string
        string seconds = Console.ReadLine();
        _duration = int.Parse(seconds);
        Console.Clear();
        // Get Ready and spinner
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        // White space
        Console.WriteLine();
        Console.WriteLine();

    }
    public void DisplayEndingMessage(){
        Console.WriteLine("Well Done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int seconds){
        // Put the animation it a string of objects
        List<string> animationString = new();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        
        // Use datetime to display spinner for a certain amount of time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        // Display spinner for specified time
        while (DateTime.Now < endTime){

            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i ++;

            if (i >= animationString.Count){
                i = 0;
            }
        }

    }
    public void ShowCountDown(int seconds){
        for(int i = seconds; i > 0; i --){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine();

    }
}