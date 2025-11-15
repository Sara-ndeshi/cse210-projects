public class Entry
{
    public string _dateTime;
    public string _prompt;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"Date & Time: {_dateTime}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_text}");
        Console.WriteLine(); //blank line
    }
}