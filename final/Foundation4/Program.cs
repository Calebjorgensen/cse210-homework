using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Console.WriteLine("Running");
        Running running = new Running("06 June 2024", 30, 5);
        Console.WriteLine(running.GetSummary());

        Console.WriteLine();

        Console.WriteLine("Cycling");
        Bicycles bicycles = new Bicycles("04 June 2024", 45, 10);
        Console.WriteLine(bicycles.GetSummary());

        Console.WriteLine();

        Console.WriteLine("Swimming");
        Swimming swimming = new Swimming("02 June 2024", 20, 20);
        Console.WriteLine(swimming.GetSummary());

        Console.WriteLine();
    }
}