using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        int submittedNumber = int.Parse(Console.ReadLine());
        int match = -1;
        while (match != submittedNumber)
        {
            Console.WriteLine("What is your guess? ");
            match = int.Parse(Console.ReadLine());

            if (submittedNumber > match)
            {Console.WriteLine("Higher");}
            else if (submittedNumber < match)
            {Console.WriteLine("Lower");}
            else
            {Console.WriteLine("You guessed it!");}
        }

         Console.WriteLine("Let's play again!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;


        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {Console.WriteLine("Higher");}
            else if (magicNumber < guess)
            {Console.WriteLine("Lower");}
            else
            {Console.WriteLine("You guessed it!");}
        }

    }
}