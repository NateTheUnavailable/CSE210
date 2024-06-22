using System;

class JournalMenu
{
    private const string SavedEntriesFilePath = @"C:\Users\nate\OneDrive\Documents\CSE210\CSE210\prove\Develop02\SavedEntries.txt";
    public void DisplayMenu()
    {
        bool exit = false;
 
        while (!exit)
        {
            Console.WriteLine("1. Create a new journal entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal entries to file");
            Console.WriteLine("4. Load journal entries from file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    SaveEntriesToFile();
                    break;
                case "4":
                    LoadEntriesFromFile();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private void CreateEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GeneratePrompt();

        Console.WriteLine(prompt);
        string entryText = Console.ReadLine();

        Entry newEntry = new Entry(DateTime.Now, prompt, entryText);
        newEntry.SaveToFile();

        Console.WriteLine("Journal entry saved successfully.");
    }

    private void DisplayEntries()
    {
        string[] entryFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");

        foreach (string file in entryFiles)
        {
            Entry entry = Entry.LoadFromFile(file);
            Console.WriteLine("\nDate: " + entry.Date);
            Console.WriteLine("Prompt: " + entry.PromptText);
            Console.WriteLine("Entry: " + entry.EntryText);
        }
    }

    private void SaveEntriesToFile()
    {
        string[] entryFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");

        using (StreamWriter sw = File.CreateText(SavedEntriesFilePath))
        {
            foreach (string file in entryFiles)
            {
                string entryText = File.ReadAllText(file);
                sw.WriteLine(entryText);
            }
        }

        Console.WriteLine("Journal entries saved to file successfully.");
    }

    private void LoadEntriesFromFile()
    {
        string savedEntriesFile = "SavedEntries.txt";

        if (File.Exists(savedEntriesFile))
        {
            string[] savedEntries = File.ReadAllLines(SavedEntriesFilePath);
            foreach (string entry in savedEntries)
            {
                Console.WriteLine(entry);
            }
        }
        else
        {
            Console.WriteLine("No saved entries found.");
        }
    }
}
