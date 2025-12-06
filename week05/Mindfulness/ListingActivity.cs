using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "List people you appreciate.",
        "List your personal strengths.",
        "List things that make you happy."
    };

    public ListingActivity()
        : base("Listing Activity",
        "This activity helps you reflect on positive aspects of your life by listing them.") { }

    public override void RunActivity()
    {
        StartMessage();

        Random rnd = new Random();
        Console.WriteLine($"\nPrompt: {_prompts[rnd.Next(_prompts.Count)]}");
        Console.WriteLine("You have 5 seconds to start thinking...");
        Countdown(5);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input.Trim());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndMessage();
    }
}
