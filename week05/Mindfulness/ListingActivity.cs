using System;
using System.Threading.Tasks.Dataflow;
public class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description) : base(name, description){
        _prompts = new();
        _prompts.Add("When was the last time you felt the Holy Ghost?");
        _prompts.Add("What make you feel closer to your savior and the atonement?");
        _prompts.Add("What do you enjoy about the temple when you go?");
        _prompts.Add("You can only be as happy as you are grateful.  What are some things you are grateful for?");
        _prompts.Add("In what ways to you go about strengthening your testimony?");
        _prompts.Add("In what situations do you go to Heavenly Father in prayer?");
        _prompts.Add("Who are people that you apprectiate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("Who are some of your personal heroes?");
        
    }
    public void Run(){
        DisplayStartingMessage();
        List<string> userList = GetListFromUser();
        _count = userList.Count();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();

    }
    public void GetRandomPrompt(){
        Random rand = new Random();
        int index;
        index = rand.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[index]} ---");

    }
    public List<string> GetListFromUser(){
        List<string> answers = new();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime){
            Console.Write(">");
            string userAnswer = Console.ReadLine();
            answers.Add(userAnswer);
        }
        return answers;

    }
}