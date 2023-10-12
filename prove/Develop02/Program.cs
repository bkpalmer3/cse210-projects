using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJornal = new Journal();
        Prompt newPrompt = new Prompt();
    
        int option = 0;

        while (option != 5)
        {

        option = DisplayMainMenu();
        switch (option)
        {
            case 1:
            
                string savePrompt = newPrompt.GetPrompt();
                Console.WriteLine(savePrompt);
                string response = Console.ReadLine();
                string dateTime = DateTime.Now.ToString();

                Entry Entry1 = new Entry(savePrompt, response, dateTime);

                myJornal.AddEntry(Entry1);
                Console.WriteLine("Your entry has been recorded.");
                break;
            
            case 2:
                myJornal.DisplayJournal();
                break;

            case 3:
                myJornal.SaveJournal();
                Console.WriteLine("Your journal has been saved.");

            break;

            case 4:
                myJornal.LoadJornal();
                Console.WriteLine("Your journal has been loaded.");

            break;

        }
        }
    }

    static int DisplayMainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu:");
        Console.WriteLine("-------------------------");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Quit");
        Console.WriteLine("-------------------------");
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        Console.WriteLine();

        int option = int.Parse(input);
        return option;
    }

}