using System;
using System.IO;

class Entry
{
    public DateTime Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public Entry(DateTime date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public void SaveToFile()
    {
        string fileName = Date.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";
        using (StreamWriter sw = File.CreateText(fileName))
        {
            sw.WriteLine($"Date: {Date}");
            sw.WriteLine($"Prompt: {PromptText}");
            sw.WriteLine($"Entry: {EntryText}");
        }
    }

    public static Entry LoadFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        DateTime date = DateTime.Parse(lines[0].Split(": ")[1]);
        string prompt = lines[1].Split(": ")[1];
        string entry = lines[2].Split(": ")[1];

        return new Entry(date, prompt, entry);
    }
}
