using System;
using System.Threading.Tasks.Dataflow;
public class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration){
        _count = count;
        List<string> _prompts = new();
        _prompts.Add("When was the last time you felt the Holy Ghost?");
        _prompts.Add("What make you feel closer to your savior and the atonement?");
        _prompts.Add("What do you enjoy about the temple when you go?");
        _prompts.Add("You can only be as happy as you are grateful.  What are some things you are grateful for?");
        _prompts.Add("In what ways to you go about strengthening your testimony?");
        _prompts.Add("In what situations do you go to Heavenly Father in prayer?");
        
    }
    public void Run(){
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.Write("How long, in seconds, would you like for your session? ");
        string seconds = Console.ReadLine();
        _duration = int.Parse(seconds);

    }
    public void GetRandomPrompt(){
        Random rand = new Random();
        int index;
        index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);


    }
    public List<string> GetListFromUser(){
        List<string> answers = new();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        for(int i = 3; i > 0; i --){
            Console.Write(i);
            Thread.Sleep(1000);
        }
        Console.Write(">");
        while(_duration > 0){
            string userAnswer = Console.ReadLine();
            answers.Add(userAnswer);
        }
        return answers;

    }
}