using System;

public class Jounral
{
    //Goals and Needs of the journal class
    // 1. This will have 4 of the menu options
    //      A. display
    //      B. load
    //      C. save
    //      D. quit
    // 2. Need to call entry from entry class. 
    // 3. 
 
    private List<Entry> entries;

    public void Journal() {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, string date) {
        entries.Add(new Entry { Prompt = prompt, Response = response, Date = date });
    }

    public void DisplayEntries() {
        foreach (var entry in entries) {
            Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
        }
    }

    public void SaveToFile(string filename) {
        using (StreamWriter writer = new StreamWriter(filename)) {
            foreach (var entry in entries) {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename) {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
                string[] parts = line.Split('|');
                if (parts.Length == 3) {
                    entries.Add(new Entry { Date = parts[0], Prompt = parts[1], Response = parts[2] });
                }
            }
        }
    }
}