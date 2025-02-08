using System;
public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description) : base(name, description){
        _questions = new List<string>();
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What was your favorite thing about this experience?");
        _questions.Add("What did you learn from this experience that helps you in your daily life?");
        _questions.Add("How did this experience change you or your way of viewing you life or the world?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        _prompts = new List<string>();
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you accomplished a goal that you set forth for yourself.");
        _prompts.Add("Think of a time when you did something that was unpopular, but aligned with your moral values.");
        _prompts.Add("Think of a time when you conquered a hurdle in your life that seemed insurmountable.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }
    public void Run(){
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();

    }
    public string GetRandomPrompt(){
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion(){
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt(){
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

    }
    public void DisplayQuestions(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime){
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(5);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}