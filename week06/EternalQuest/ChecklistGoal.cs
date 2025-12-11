using System;

class ChecklistGoal : Goal
{
    public int _timesCompleted { get; set; }
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, int points, int target, int bonus)
    {
        Name = name;
        Points = points;
        _target = target;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override void RecordEvent(ref int totalScore)
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted++;
            totalScore += Points;
            Console.WriteLine($"Goal progress! You earned {Points} points. ({_timesCompleted}/{_target})");

            if (_timesCompleted == _target)
            {
                totalScore += _bonus;
                Console.WriteLine($"Checklist complete! Bonus awarded: {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine("This checklist goal is already complete.");
        }
    }

    public override string GetStringRepresentation() => $"ChecklistGoal:{Name},{Points},{_timesCompleted},{_target},{_bonus}";
    public override void DisplayGoal() => Console.WriteLine($"[{_timesCompleted}/{_target}] {Name}");
}
