using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Word word = new Word("For God so loved the world that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
        
        Scripture scripture = new Scripture(reference, word);

        while (true)
        {
            scripture.DisplayScripture();
        }
    }
}
