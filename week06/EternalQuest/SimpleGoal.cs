using System;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public override void RecordEvent(ref int totalScore)
    {
        if (!_isComplete)
        {
            totalScore += Points;
            _isComplete = true;
            Console.WriteLine($"Goal completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override string GetStringRepresentation() => $"SimpleGoal:{Name},{Points},{_isComplete}";
    public override void DisplayGoal() => Console.WriteLine($"{(_isComplete ? "[X]" : "[ ]")} {Name}");
}
