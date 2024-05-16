using System;

class Program
{
    static void Main(string[] args)
    {
        var scritpure = new Scripture(new Reference("Mosiah", 2,17), "And behold, I tell you these things that ye may learn wisdoom; that ye may learn that when ye are in the sevice of your fellow beings ye are only in the service of your God.");

        while(!scritpure.AllWordsHidden)
        {
            Console.Clear();
            Console.WriteLine(scritpure);
            Console.WriteLine("\nCLick Enter to hide a word or type quit to exit the program.");
            string input = Console.ReadLine();
            if (input == "quit") return;

            scritpure.HideRandomWords(); 
        }

        Console.Clear();
        Console.WriteLine("All words are hidden.");
    }
}