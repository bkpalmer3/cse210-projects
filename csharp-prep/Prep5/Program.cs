using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine ("Welcome to the Program");
        }
        static string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine ();
            return name;
        }
        static int PromptUserNumber ()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        static void DisplayResult (string userName, int number)
        {
            Console.WriteLine ($"{userName}, The square root of your favorite number is {number} ");
        }

        DisplayMessage();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int sqrtFavNumber = SquareNumber(favNumber);
        DisplayResult (userName, sqrtFavNumber);

}}