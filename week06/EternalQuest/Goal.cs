using System;

abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }

    public abstract void RecordEvent(ref int totalScore);
    public abstract string GetStringRepresentation();
    public abstract void DisplayGoal();
}
