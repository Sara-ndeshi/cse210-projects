using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string playAgain = "yes";

        while (playAgain.ToLower()=="yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1,101); //1 to 100 inclusive
            int guessCount = 0;
            int guess = -1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }
            Console.Write("Would you like to play again (yes/no)? ");
            playAgain = Console.ReadLine();

        }
    }
}