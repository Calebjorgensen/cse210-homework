using System;

class Program
{
    static void Main(string[] args)
    {
        var scritpure = new Scripture(new Reference("Test", 1,2,3), "This is a test to see if this works?");

        while(!scritpure.AllWordsHidden)
        {
            Console.Clear();
            Console.WriteLine(scritpure);
            Console.WriteLine("\nCLick Enter to hide a word or type quit to exit the program.");
            string input = Console.ReadLine();
            if (input == "qiutt") return;

            scritpure.HideRandomWords(); 
        }

        Console.Clear();
        Console.WriteLine("All words are hidden.");
    }
}