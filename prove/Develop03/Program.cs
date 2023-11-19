using System;

class Program
{
    static void Main(string[] args)
    {
        Verse verse1 = new Verse("And this is life eternal, that they might know thee the one true God and Jesus Christ, whom thou hast sent.");
        Reference verse1Reference = new Reference("John", "17", "3");
        Scripture scripture1 = new Scripture(verse1Reference, verse1);

        verse1.BuildWordList();
        string userInput = "";

        while (userInput != "quit")
        {
            scripture1.DisplayScripture();
            verse1.RemoveWords();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press the enter key or type 'quit'");
            userInput = Console.ReadLine();

            Console.Clear();

            bool allHidden = verse1.CheckHidden();
            if (allHidden == true)
            {
                break;
            }

        }

        scripture1.DisplayScripture();
        Console.WriteLine();
        Console.WriteLine("Thanks for Memorizing!!!");
    }
}