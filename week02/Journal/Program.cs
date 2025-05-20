using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do: ");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    Entry newEntry = new Entry(date, prompt, response);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added.\n");
                    break;

                case 2:
                    Console.WriteLine("\nYour Journal Entries:");
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved.\n");
                    break;

                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded.\n");
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Please choose a valid option (1-5).\n");
                    break;
            }
        }
    }
}
