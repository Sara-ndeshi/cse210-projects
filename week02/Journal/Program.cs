// Creative feature: Each journal entry include the exact time it was written.

using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        //create a Journal and PromptGenerator
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        //Loop for the menu
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choice:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                //Get a random prompt
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.WriteLine(prompt);
                Console.Write(">");

                //get user's response
                string userEntry = Console.ReadLine();

                //create a new Entry object
                Entry entry = new Entry();
                entry._dateTime = DateTime.Now.ToString("g"); //current date
                entry._prompt = prompt;
                entry._text = userEntry;

                //add entry to the journal
                journal.AddEntry(entry);

                Console.WriteLine("Entry added!\n");
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.saveToFile(filename);
                Console.WriteLine("Journal saved!\n");
            }

            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal is loaded!\n");
            }

            else if (choice == "5")
            {
                running = false; // exit the loop
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid choice. Try again.\n");
            }
        }
    }
}