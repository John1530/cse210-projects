using System;
using System.IO;

public static class ActivityLog
{
    private static int _breathingCount = 0;
    private static int _reflectionCount = 0;
    private static int _listingCount = 0;
    private static int _gratitudeCount = 0;

    public static void LogActivity(string activityName)
    {
        string line =
            $"{DateTime.Now}: {activityName} completed";

        File.AppendAllText(
            "activitylog.txt",
            line + Environment.NewLine);

        switch (activityName)
        {
            case "Breathing Activity":
                _breathingCount++;
                break;

            case "Reflection Activity":
                _reflectionCount++;
                break;

            case "Listing Activity":
                _listingCount++;
                break;

            case "Gratitude Activity":
                _gratitudeCount++;
                break;
        }
    }

    public static void DisplayStats()
    {
        Console.WriteLine();
        Console.WriteLine("Activity Statistics");
        Console.WriteLine("--------------------");
        Console.WriteLine($"Breathing: {_breathingCount}");
        Console.WriteLine($"Reflection: {_reflectionCount}");
        Console.WriteLine($"Listing: {_listingCount}");
        Console.WriteLine($"Gratitude: {_gratitudeCount}");
    }
}