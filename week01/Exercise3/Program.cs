using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("What is the magic number? ");
      string magic = Console.ReadLine();  
      int magicNumber = int.Parse(magic);

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