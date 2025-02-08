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
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for you session? ");
        string seconds = Console.ReadLine();
        _duration = int.Parse(seconds);
        Console.Clear();
        ShowSpinner(3);
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();

    }
    public void DisplayEndingMessage(){
        Console.WriteLine("");
    }
    public void ShowSpinner(int seconds){
        List<string> animationString = new();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

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

    }
}