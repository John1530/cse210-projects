using System;

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
                String promt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {promt}");
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = promt;
                newEntry._entryText = response;
                journal.AddEntry(newEntry);

            }
            else if (choice == 2)
            {
                Console.WriteLine("\nJournal Entries:");
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename to save: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);

                Console.WriteLine("Journal loaded successfully.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename to load: ");
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