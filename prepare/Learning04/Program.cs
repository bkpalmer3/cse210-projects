using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Ben Palmer", "addition","Section 7.3", "Problems 9-12");
        WritingAssignment assignment2 = new WritingAssignment("Ben Palmer", "history","History has its eyes on you");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList());

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}