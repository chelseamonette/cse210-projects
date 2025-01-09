using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        int guessNumber;
        do{
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        guessNumber = int.Parse(guess);

        if (guessNumber < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        } while (guessNumber != magicNumber);
    }
}