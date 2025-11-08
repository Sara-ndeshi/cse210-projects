using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        //Input: ask the user for their percentage score.
        Console.Write("Enter your percentage score: ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);
        
        //Get the last digit of the score (ones place)
        int lastDigit = score % 10;

        //Initialize variables (letter grade & sign (+/-))
        string symbol = "";
        string sign = "";

        //determine the letter grade based on score
        if (score >= 90)
        {
            symbol = "A";
        }
        else if (score >= 80)
        {
            symbol = "B";
        }
        else if (score >= 70)
        {
            symbol = "C";
        }
        else if (score >= 60)
        {
            symbol = "D";
        }
        else
        {
            symbol = "F";
        }

        // determine the sign (+/-) for grades B, C, D
        // F never gets a + or -
        if (symbol != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        // Special case: there is no A+ grade
        if ((symbol == "A") && (sign == "+"))
        {
            sign = "";
        }
        
        //Special case: F never has a sign
        if (symbol == "F")
        {
            sign = "";
        }

        //Display the final grade with sign
        Console.Write($"Your grade is {symbol}{sign} ");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations, You passed!");

        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
    
}