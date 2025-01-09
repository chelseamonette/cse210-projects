using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int newNumber;
        float sumNumbers = 0;
        float average;

        do{
            Console.Write("Enter number: ");
            string enter = Console.ReadLine();
            newNumber = int.Parse(enter);

            numbers.Add(newNumber);
            sumNumbers += newNumber;

        } while (newNumber != 0);

        Console.WriteLine($"The sum is: {sumNumbers}");

        float amountNumbers = numbers.Count - 1;
        average = sumNumbers / amountNumbers;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}