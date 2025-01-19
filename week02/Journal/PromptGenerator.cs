// Supplies random prompts whenever needed
using System.Reflection.Metadata.Ecma335;

public class PromptGenerator
{
    //_prompts : List<string>
    private static List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing that I am especially grateful to God for today?",
        "What challenges did I face today and how did I overcome them?",
        "What could I have done differently today?"

    };

    //GetRandomPrompt() : string
    public static string GetRandomPrompt()
    {
        // Random object
        Random random = new Random();

        // Get random index
        int index = random.Next(_prompts.Count);

        // Return random prompt
        return(_prompts[index]);

    }
   
}