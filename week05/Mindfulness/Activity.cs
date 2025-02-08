using System;
public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage(){
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for you session? ");
        string seconds = Console.ReadLine();
        _duration = int.Parse(seconds);
        Console.Clear();
        ShowSpinner(3);
        Console.WriteLine("Get Ready...");
        for(int i = 5; i > 0; i --){
            
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("'\'");


        }
        

    }
    public void DisplayEndingMessage(){
        Console.WriteLine("");
    }
    public void ShowSpinner(int seconds){

    }
    public void ShowCountDown(int seconds){

    }
}