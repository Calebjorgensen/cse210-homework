using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int gradeNumber = int.Parse(userInput);

        string letter = "";

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You grade is {letter}");
        Console.WriteLine("");

        if (gradeNumber >= 70)
        {
            Console.WriteLine($"Great work you earned a {letter}");
        }
        else
        {
            Console.WriteLine($"You earned a {letter}, please retake");
        }

    }
}