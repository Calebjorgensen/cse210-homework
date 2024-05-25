using System;

public class SaveLoad{
    SimpleGoal simple = new SimpleGoal();
    EternalGoal eternal = new EternalGoal();
    ChecklistGoal checklist = new ChecklistGoal();

    public void SaveGoals(int score)
    {
        Console.WriteLine("Enter the name of the file you wish to create: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(score);

            outputFile.WriteLine("Simple Goals: ");
            foreach (Object i in simple._simpleList){
                outputFile.WriteLine(i);
            }
            outputFile.WriteLine("Eternal Goals: ");
            foreach (Object i in eternal._eternalList){
                outputFile.WriteLine(i);
            }

            outputFile.WriteLine("Checklist Goals: ");
            foreach (Object i in checklist._checklistList){
                outputFile.WriteLine(i);
            }
        }
    }

    public int LoadGoals()
    {
        Console.WriteLine("Enter the name of the file you wish to loadL: ");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);

        
        List<string> simpleGoals = new List<string>();
        List<string> eternalGoals = new List<string>();
        List<string> checklistGoals = new List<string>();

        int score = int.Parse(lines[0]);

        int currentLineIndex = 1;

        while (currentLineIndex < lines.Length && !lines[currentLineIndex].StartsWith("Eternal Goals: "))
        {
            simpleGoals.Add(lines[currentLineIndex]);
            currentLineIndex++;
        }

        currentLineIndex++;
        while (currentLineIndex < lines.Length && !lines[currentLineIndex].StartsWith("Checklist Goals: "))
        {
            eternalGoals.Add(lines[currentLineIndex]);
            currentLineIndex++;
        }

        currentLineIndex++;
        while (currentLineIndex < lines.Length)
        {
            checklistGoals.Add(lines[currentLineIndex]);
            currentLineIndex++;
        }

        Console.WriteLine($"Score: {score}");

        Console.WriteLine("Simple Goals: ");
        simple.DisplayGoals();

        Console.WriteLine("Eternal Goals: ");
        eternal.DisplayGoals();

        Console.WriteLine("Checklist Goals: ");
        checklist.DisplayGoals();

        return score;
    }
}