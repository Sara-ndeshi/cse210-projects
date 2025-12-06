using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax with slow breathing. Clear your mind and focus on your breath.") { }

    public override void RunActivity()
    {
        // Display start message and get duration
        StartMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);
        bool inhale = true;

        while (DateTime.Now < end)
        {
            if (inhale)
            {
                Console.Write("\nBreathe in... ");
                Countdown(4);
            }
            else
            {
                Console.Write("Breathe out... ");
                Countdown(4);
            }
            inhale = !inhale;
            Console.WriteLine();
        }

        // Display ending message and log the session
        EndMessage();
    }
}
