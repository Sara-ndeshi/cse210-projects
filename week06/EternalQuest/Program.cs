using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;
    static string saveFile = "goals.txt";

    static void Main()
    {
        LoadGoals();

        while (true)
        {
            Console.WriteLine("\n--- Eternal Quest Menu ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save and Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": ShowScore(); break;
                case "5": SaveGoals(); return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type: 1. Simple 2. Eternal 3. Checklist");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            goals.Add(new SimpleGoal { Name = name, Points = points });
        else if (type == "2")
            goals.Add(new EternalGoal { Name = name, Points = points });
        else if (type == "3")
        {
            Console.Write("Enter target number of times to complete: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, points, target, bonus));
        }

        Console.WriteLine("Goal created!");
    }

    static void ListGoals()
    {
        Console.WriteLine("\n--- Your Goals ---");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayGoal();
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
            goals[index].RecordEvent(ref totalScore);
        else
            Console.WriteLine("Invalid selection.");
    }

    static void ShowScore()
    {
        Console.WriteLine($"Your total score: {totalScore}");
        Console.WriteLine($"Your level: {totalScore / 1000 + 1}");
    }

    static void SaveGoals()
    {
        using StreamWriter writer = new StreamWriter(saveFile);
        writer.WriteLine(totalScore); // save score first
        foreach (var goal in goals)
            writer.WriteLine(goal.GetStringRepresentation());
        Console.WriteLine("Goals and score saved!");
    }

    static void LoadGoals()
    {
        if (!File.Exists(saveFile)) return;

        string[] lines = File.ReadAllLines(saveFile);
        if (lines.Length == 0) return;

        totalScore = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            Goal g = GoalFactory.CreateGoalFromString(lines[i]);
            if (g != null) goals.Add(g);
        }

        Console.WriteLine("Goals loaded!");
    }
}
