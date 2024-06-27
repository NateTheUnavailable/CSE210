using System;
using System.Linq;

public class Scripture
{
    private Reference scriptureReference;
    private Word scriptureText;

    public Scripture(Reference reference, Word word)
    {
        scriptureReference = reference;
        scriptureText = word;
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"Reference: {scriptureReference.Book} {scriptureReference.Chapter}:{scriptureReference.Verse}");
        Console.WriteLine("Scripture:");
        string[] words = scriptureText.Text.Split(' ');

        // Randomly hide some words for memorization
        Random random = new Random();
        int wordsToHide = words.Length / 3; // Hiding one-third of the words
        int[] hiddenIndices = Enumerable.Range(0, words.Length).OrderBy(x => random.Next()).Take(wordsToHide).ToArray();

        for (int i = 0; i < words.Length; i++)
        {
            if (hiddenIndices.Contains(i))
            {
                Console.Write("________ ");
            }
            else
            {
                Console.Write(words[i] + " ");
            }
        }

        Console.WriteLine("\nType 'exit' to leave the program.");

        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "exit")
        {
            Environment.Exit(0); // Exit the program
        }
    }
}
