using System;

class Program
{
    static void Main(string[] args)
    {
       WelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = NumberSquared(userNumber);

        FinalNumber(userName, squaredNumber);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int NumberSquared(int number)
    {
        int square = number * number;
        return square;
    }

    static void FinalNumber(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}