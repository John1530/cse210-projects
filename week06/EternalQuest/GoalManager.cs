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
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(
                name,
                description,
                points,
                target,
                bonus));
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nGoals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you complete? ");
        int choice = int.Parse(Console.ReadLine());

        int points = _goals[choice - 1].RecordEvent();

        _score += points;

        Console.WriteLine($"You earned {points} points!");
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
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }

        Console.WriteLine("Goals loaded.");
    }
}