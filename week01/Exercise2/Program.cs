using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage do you have? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        if (grade >= 90)
        {
            Console.WriteLine("You earned an A");
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("You earned a B");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("You earned a C");
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("You earned a D");
        }
        else 
        {
            Console.WriteLine("You earned an F");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not earn a high enough grade to pass. Better luck next time.");
        }
    }
}