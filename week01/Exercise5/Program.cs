using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); //show welcome message
        string name = PromptUserName(); //get user name
        int number = PromptUserNumber(); //get favorite number
        int squared = SquareNumber(number); //calculate the square
        DisplayResult(name, squared); //print the final message
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to Program!");
    }
    static string PromptUserName()
    {
        //ask for user's name and send it back to main
        Console.Write("Please enter your name: "); 
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        ////ask for user favorite number and send it back to main
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static int SquareNumber(int number)
    {
        int result = number * number; //multiply the number by itself
        return result; //send the squared value back to the main
    }
    static void DisplayResult(string name, int squared)
    {
        //print the final message using string interpolation.
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
} 