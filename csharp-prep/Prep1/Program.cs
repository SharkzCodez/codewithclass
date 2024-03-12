using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string firstname = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastname = Console.ReadLine();
        Console.Write($"Your name is {lastname}. {firstname} {lastname}.");
    }
}