using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        string playerInput = "";
        int playerGuess = 0;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        do 
        {

            Console.Write("What is your guess? ");
            playerInput = Console.ReadLine ();
            playerGuess = int.Parse (playerInput);

            if (playerGuess > magicNumber)
            {
                Console.WriteLine ("Lower");
            }
            else if (playerGuess < magicNumber)
            {
                Console.WriteLine ("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (playerGuess != magicNumber);
    }
}