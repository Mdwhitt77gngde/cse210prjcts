using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new scripture with a reference and text
        Scripture scripture = new Scripture(new Reference("Proverbs", 3, 5, 6), 
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine("All words are now hidden! Memorization complete.");
    }
}
