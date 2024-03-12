using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percent?");
        string reply = Console.ReadLine();
        int percent = int.Parse(reply);

        string grade = "";
        if (percent >= 90)
        {grade = "A";}
        else if (percent >= 80)
        {grade = "B";}
        else if (percent >= 70)
        {grade = "C";}
        else if (percent >= 60)
        {grade = "D";}
        else {grade = "F";}

        Console.WriteLine($"Your grade is {grade}");
        if (percent >= 70)
        {Console.Write("Congratulations! You passed!");}
        else
        {Console.Write("You failed. Try again.");}
    }
}