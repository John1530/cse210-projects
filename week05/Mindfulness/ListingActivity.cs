using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    private List<string> _unusedPrompts;

    public ListingActivity()
        : base(
            "Listing Activity",
            "List as many positive things as you can.")
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    private string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }

        Random rand = new Random();

        int index = rand.Next(_unusedPrompts.Count);

        string prompt = _unusedPrompts[index];

        _unusedPrompts.RemoveAt(index);

        return prompt;
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine("\nList as many responses as you can:");

        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");

        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);

        int count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items.");

        EndActivity();

        ActivityLog.LogActivity("Listing Activity");
    }
}