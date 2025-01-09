using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage do you have? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        string letterGrade = grade.ToString();

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letterGrade = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }

        Console.WriteLine($"You earned a {letterGrade}");

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