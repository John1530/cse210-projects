using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _gratitudePrompts = new List<string>
    {
        "What made you smile today?",
        "Who are you thankful for today?",
        "What opportunity are you grateful for?",
        "What challenge taught you something valuable?",
        "What is something beautiful you noticed recently?"
    };

    public GratitudeActivity()
        : base(
            "Gratitude Activity",
            "Focus on things you are grateful for and develop a positive mindset.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(
                _gratitudePrompts[rand.Next(_gratitudePrompts.Count)]);

            ShowSpinner(6);
        }

        EndActivity();

        ActivityLog.LogActivity("Gratitude Activity");
    }
}