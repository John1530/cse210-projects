using System;

/*
 * Creativity and Exceeding Requirements:
 *
 * 1. Added a Gratitude Activity that encourages users
 *    to focus on positive experiences and gratitude.
 *
 * 2. Added an Activity Statistics feature that tracks
 *    how many times each activity has been completed.
 *
 * 3. Added an Activity Log that saves completed
 *    activities to a text file named activitylog.txt.
 *
 * 4. Modified Reflection and Listing activities so
 *    prompts/questions are not repeated until all
 *    available prompts/questions have been used.
 */

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Gratitude Activity");
            Console.WriteLine("5. View Statistics");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;

                case "2":
                    new ReflectionActivity().Run();
                    break;

                case "3":
                    new ListingActivity().Run();
                    break;

                case "4":
                    new GratitudeActivity().Run();
                    break;

                case "5":
                    ActivityLog.DisplayStats();
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}