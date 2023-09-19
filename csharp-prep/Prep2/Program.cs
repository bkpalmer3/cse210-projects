using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write ("What is your grade percentage? ");
        string userInput = Console.ReadLine ();
        int gradePercent = int.Parse (userInput);
        string letter = " ";

       if (gradePercent >= 90)
       {
            letter = "A";
       }
       else if (gradePercent >= 80)
       {
            letter = "B";    
        }
       else if (gradePercent >= 70)
       {
            letter = "C";
       }
       else if (gradePercent >= 60)
       {
            letter = "D";
       }
       else if (gradePercent < 60)
       {
            letter = "F";
       }

        Console.WriteLine ($"Your grade is {letter}");

       if (gradePercent >= 70)
       {
            Console.WriteLine ("Congrats you passed!");
       }
       else 
       {
            Console.WriteLine ("That's not a passing grade :(, Better luck next time!");
       }

}}