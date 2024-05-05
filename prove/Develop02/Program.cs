using System;

class Program
{
    static void Main(string[] args)
    {
        //Goals and needs of the program
        // 1. Menu will need to be build. With 5 option. 
        //      if() or switch case
        // 2. It will need to connect to jounral class.
        // 3. Will propbably not connect to entry class, that will loop through journal then to program.
        // 4. 
        
        Journal journal = new Journal();

        bool running = true;
        while (running) {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    WriteNewEntry(journal);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournalToFile(journal);
                    break;
                case "4":
                    LoadJournalFromFile(journal);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal) {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random rand = new Random();
        string randomPrompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        journal.AddEntry(randomPrompt, response, DateTime.Now.ToString());
    }

    static void SaveJournalToFile(Journal journal) {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved successfully.");
    }

    static void LoadJournalFromFile(Journal journal) {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded successfully.");
    }
}
