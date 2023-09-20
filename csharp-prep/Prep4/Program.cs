using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        do
        {
        Console.Write ("'Give me a number (typer 0 when done): ");
        number = int.Parse(Console.ReadLine());

        if (number != 0)
        {
            numbers.Add(number);
        }
        } while (number != 0);

        int sum = 0;
        int largest = 0;

        foreach (int num in numbers)
        {
            sum = sum + num;
            if (num > largest)
            {
                largest = num;
            }
        }

        int count = numbers.Count ();
        int average = sum / count;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The Largest number is {largest}");
    }
}