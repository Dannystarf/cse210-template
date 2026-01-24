using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        PromptGenerator promptGen = new PromptGenerator();

        bool isRunning = true;

        Console.WriteLine("Welcome to the Journal Program");

        while (isRunning)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            int choice;
            bool isvalid = int.TryParse(Console.ReadLine(), out choice);

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);

                string response = Console.ReadLine();

                string date = DateTime.Now.ToString("yyyy-MM-dd");

                Entry userEntry = new Entry();
                userEntry._date = date;
                userEntry._entryText = response;
                userEntry._promptText = prompt;

                theJournal.AddEntry(userEntry);
            }

            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (choice == 4)
            {
                Console.WriteLine("Enter the name you want to save this entry");

                string fileNameSave = Console.ReadLine();

                theJournal.SaveToFile(fileNameSave);
            }

            else if (choice == 3)
            {
                Console.WriteLine("Enter the name of the entry you want to load");

                string fileNameLoad = Console.ReadLine();

                theJournal.LoadFromFile(fileNameLoad);
            }

            else if (choice == 5)
            {
                isRunning = false;
            }

            else
            {
                Console.WriteLine("Please choose a number between 1 and 5.");
            }
        }
    }
}