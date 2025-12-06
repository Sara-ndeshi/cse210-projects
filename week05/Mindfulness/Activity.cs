using System;
using System.IO;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---\n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long (in seconds) would you like this session to last? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        Spinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nGreat job! You completed the activity!");
        Spinner(3);
        Console.WriteLine($"\nYou completed {_name} for {_duration} seconds.");
        Spinner(3);

        // EXTRA FEATURE: Save session to log file
        SaveToLog();
        Console.WriteLine("\nSession saved to activity_log.txt");
        Spinner(2);
    }

    public void Spinner(int seconds)
    {
        string[] spin = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spin[i % spin.Length]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Log activity to file
    private void SaveToLog()
    {
        string entry = $"{DateTime.Now} — Completed {_name} for {_duration} seconds.";
        File.AppendAllText("activity_log.txt", entry + Environment.NewLine);
    }

    public abstract void RunActivity();
}
