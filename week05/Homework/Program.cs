using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new("Chelsea Monette", "Inheritance");
        // string summary = assignment.GetSummary();
        // Console.WriteLine(summary);
        // MathAssignment mathAssignment = new("Chelsea Monette", "Inheritance", "7.3", "189-190");
        //string summary = mathAssignment.GetSummary();
        //string newAssigment = mathAssignment.GetHomeworkList();
        //Console.WriteLine(summary);
        //Console.WriteLine(newAssigment);
        WritingAssignment writingAssignment = new("Chelsea Monette", "European History", "The Causes of World War II");
        string summary = writingAssignment.GetSummary();
        string title = writingAssignment.GetWritingInformation();
        Console.WriteLine(summary);
        Console.WriteLine(title);

         

    }
}