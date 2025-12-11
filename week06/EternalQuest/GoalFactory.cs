using System;

static class GoalFactory
{
    public static Goal CreateGoalFromString(string line)
    {
        string[] parts = line.Split(':');
        string type = parts[0];
        string[] data = parts[1].Split(',');

        return type switch
        {
            "SimpleGoal" => new SimpleGoal
            {
                Name = data[0],
                Points = int.Parse(data[1]),
            },
            "EternalGoal" => new EternalGoal
            {
                Name = data[0],
                Points = int.Parse(data[1])
            },
            "ChecklistGoal" => new ChecklistGoal(data[0], int.Parse(data[1]), int.Parse(data[3]), int.Parse(data[4]))
            {
                _timesCompleted = int.Parse(data[2])
            },
            _ => null
        };
    }
}
