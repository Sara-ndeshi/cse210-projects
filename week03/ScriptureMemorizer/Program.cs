/*
Assignment: W03 Scripture Memorizer Program

Creativity / Exceeding Requirements:
I made the program show different scriptures randomly, 
use progressive word hiding with the Hide() method so it doesn’t re-hide words, 
and display the number of hidden words to track memorization.
*/


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life."
        ));

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to Him, and He will make your paths straight."
        ));

        scriptures.Add(new Scripture(
            new Reference("Psalm", 23, 1),
            "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures, He leads me beside quiet waters."
        ));

        // Pick a random scripture
        Random rand = new Random();
        Scripture currentScripture = scriptures[rand.Next(scriptures.Count)];

        // Main loop
        while (true)
        {
            Console.Clear();
            currentScripture.Display();

            // Show progress
            int hidden = currentScripture.GetHiddenWordCount();
            int total = currentScripture.TotalWordCount();
            Console.WriteLine($"Progress: {hidden}/{total} words hidden.\n");

            if (currentScripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.WriteLine("Press Enter to hide some words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            currentScripture.HideRandomWords(3); // hide 3 words per Enter
        }
    }
}
