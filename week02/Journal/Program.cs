using System;

// Exceeded requirements by adding mood tracking
// for each journal entry and implementing JSON
// file storage instead of plain text storage.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Select a Choice: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("> ");

                string response = Console.ReadLine();
                int wordCount = response.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

                Console.Write("Mood: ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;
    
                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nJournal Entries:");
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename to load: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);

                Console.WriteLine("Journal loaded successfully.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename to save: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);

                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
            }
            
        }
    }
}