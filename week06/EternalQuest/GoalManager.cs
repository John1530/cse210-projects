using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayPlayerInfo()
    {
        int level = (_score / 1000) + 1;

        Console.WriteLine("\n==============================");
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine($"Level: {level}");

        if (level >= 10)
        {
            Console.WriteLine("Title: Goal Master");
        }
        else if (level >= 5)
        {
            Console.WriteLine("Title: Goal Warrior");
        }
        else if (level >= 3)
        {
            Console.WriteLine("Title: Goal Explorer");
        }
        else
        {
            Console.WriteLine("Title: Beginner");
        }

        Console.WriteLine("==============================\n");
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select Goal Type: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == 3)
        {
            Console.Write("Target Count: ");
            int targetCount = int.Parse(Console.ReadLine());

            Console.Write("Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(
                new ChecklistGoal(
                    name,
                    description,
                    points,
                    targetCount,
                    bonus));
        }

        Console.WriteLine("Goal created successfully!");
    }

    public void ListGoals()
    {
        Console.WriteLine("\nGoals:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        ListGoals();

        Console.Write("\nWhich goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        int pointsEarned = _goals[choice - 1].RecordEvent();

        _score += pointsEarned;

        Console.WriteLine($"\nYou earned {pointsEarned} points!");
        Console.WriteLine($"Total Score: {_score}");

        int level = (_score / 1000) + 1;
        Console.WriteLine($"Current Level: {level}");
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "SimpleGoal")
            {
                _goals.Add(
                    new SimpleGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        bool.Parse(parts[4])));
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(
                    new EternalGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3])));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                _goals.Add(
                    new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[5]),
                        int.Parse(parts[4]),
                        int.Parse(parts[6])));
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }
}