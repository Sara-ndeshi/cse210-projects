using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        //create a resizable list to hold numbers
        List<int> numbers = new List<int>();

        //keep looping until the user types 0
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber); //add number to the list.
            }
        }
        Console.WriteLine("You entered this numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        //sum calculation
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //calculate & print average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find largest number
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        //Stretch Challenge

        //find smallest positive number
        int? smallestPositive = null;

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (smallestPositive == null || number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        }
        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is:{smallestPositive}");
        }
        else

            Console.WriteLine($"There are no posistive numbers in the list.");

        //Sort numbers in the list & display sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        }  

    }