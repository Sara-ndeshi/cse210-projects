using System;

class EternalGoal : Goal
{
    public override void RecordEvent(ref int totalScore)
    {
        totalScore += Points;
        Console.WriteLine($"Goal recorded! You earned {Points} points.");
    }

    public override string GetStringRepresentation() => $"EternalGoal:{Name},{Points}";
    public override void DisplayGoal() => Console.WriteLine($"[∞] {Name}");
}
