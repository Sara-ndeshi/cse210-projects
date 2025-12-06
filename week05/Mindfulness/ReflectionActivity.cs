using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you were brave.",
        "Think of a time you overcame a challenge."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful?",
        "How did you feel afterwards?",
        "What did you learn from this experience?",
        "How can you use this experience in the future?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
        "This activity helps you reflect on moments when you demonstrated strength and resilience.") { }

    public override void RunActivity()
    {
        StartMessage();

        Random rnd = new Random();
        Console.WriteLine($"\nPrompt: {_prompts[rnd.Next(_prompts.Count)]}");
        Spinner(3);

        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine($"\n> {_questions[rnd.Next(_questions.Count)]}");
            Spinner(5);
        }

        EndMessage();
    }
}
