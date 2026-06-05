using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "What is your favorite thing about this experience?"
    };

    private List<string> _unusedQuestions;

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "Reflect on moments of strength and resilience.")
    {
        _unusedQuestions = new List<string>(_questions);
    }

    private string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        Random rand = new Random();

        int index = rand.Next(_unusedQuestions.Count);

        string question = _unusedQuestions[index];

        _unusedQuestions.RemoveAt(index);

        return question;
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {_prompts[rand.Next(_prompts.Count)]} ---");

        Console.WriteLine("\nWhen you have something in mind press Enter.");
        Console.ReadLine();

        Console.WriteLine("\nReflect on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n> {GetRandomQuestion()}");
            ShowSpinner(5);
        }

        EndActivity();

        ActivityLog.LogActivity("Reflection Activity");
    }
}