using System;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        string user;

        SaveLoad saveload = new SaveLoad();
        SimpleGoal simple = new SimpleGoal();
        EternalGoal eternal = new EternalGoal();
        ChecklistGoal checklist = new ChecklistGoal();

        Console.WriteLine("Welcome to the Eternal Qeust! ");

        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Manage Gaols");
            Console.WriteLine("2. Show Score");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your Choice: ");
            user = Console.ReadLine();

            switch (user)
            {
                case "1":
                score = ManageGoals(score);
                break;

                case "2":
                Console.WriteLine($"You've current score is: {score}! ");
                break;

                case "3":
                saveload.SaveGoals(score);
                break;

                case "4":
                score = saveload.LoadGoals();
                break;

                case "0":
                Console.WriteLine("Exiting the program. Goodbye!");
                return;
                default:
                Console.WriteLine("Invalid choice, Please try again");
                break;
            }
        }

        int ManageGoals(int points){
            string goal;

            Console.Clear();
            while(true){
                Console.WriteLine("\n What would you like to do? ");
                Console.WriteLine("1. Add Goal");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Display Goals");
                Console.WriteLine("0. Back");

                Console.WriteLine("\nEnter your choice");
                user = Console.ReadLine();

                switch (user)
                {
                    case "1":
                    goal = GoalSelection();
                    if(goal == "simple"){
                        simple.AddGoal();
                    }
                    else if (goal == "eternal"){
                        eternal.AddGoal();
                    }
                    else if(goal == "checklist"){
                        checklist.AddGoal();
                    }
                    break;

                    case "2":
                    goal = GoalSelection();
                    if(goal == "simple"){
                        points += simple.RecordEvent();
                    }
                    else if(goal == "eternal"){
                        points += eternal.RecordEvent();
                    }
                    else if(goal == "checklist"){
                        points += checklist.RecordEvent();
                    }
                    break;

                    case "3":
                    goal = GoalSelection();
                    if(goal == "simple"){
                        simple.DisplayGoals();
                    }
                    else if(goal == "eternal"){
                        eternal.DisplayGoals();
                    }
                    else if(goal == "checklist"){
                        checklist.DisplayGoals();
                    }
                    break;

                    case "0":
                    Console.WriteLine("Going back to main menu");
                    return points;
                    default:
                    Console.WriteLine("Invalid choice. Please try again");
                    break;
                }
            }
        }

        string GoalSelection()
        {
            while (true){
                Console.WriteLine("\nSelect to Goal: ");
                Console.WriteLine("1. Simple Goals");
                Console.WriteLine("2. Eternal Goals");
                Console.WriteLine("3. Checklist");
                Console.WriteLine("0. Back");

                Console.WriteLine("\nEnter your choice");
                user = Console.ReadLine();

                switch(user)
                {
                    case "1":
                    return "simple";

                    case "2":
                    return "eternal";

                    case "3":
                    return "checklist";

                    case "0":
                    Console.WriteLine("Going back to main menu.");
                    return "";
                    default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }
            }
        }
    }
}