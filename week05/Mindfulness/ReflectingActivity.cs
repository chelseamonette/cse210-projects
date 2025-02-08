using System;
public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration){
        List<string> _questions = new();
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What was your favorite thing about this experience?");
        _questions.Add("What did you learn from this experience that helps you in your daily life?");
        _questions.Add("How did this experience change you or your way of viewing you life or the world?");

        List<string>_prompts = new();
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you accomplished a goal that you set forth for yourself.");
        _prompts.Add("Think of a time when you did something that was unpopular, but aligned with your moral values.");
        _prompts.Add("Think of a time when you conquered a hurdle in your life that seemed insurmountable.");
    }
    public void Run(){
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for you session? ");
        string seconds = Console.ReadLine();
        _duration = int.Parse(seconds);
        Console.Clear();
        ShowSpinner(3);
        DisplayQuestions();
        DisplayEndingMessage();

    }
    public string GetRandomPrompt(){
        Random rand = new Random();
        int index = rand.Next(_prompts.Count());
        return _prompts[index];
    }
    public string GetRandomQuestion(){
        Random rand = new Random();
        int index = rand.Next(_questions.Count());
        return _questions[index];
    }
    public void DisplayPrompt(){
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

    }
    public void DisplayQuestions(){
        Console.Clear();
        while(_duration < 0){
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(5);
        }

    }
}