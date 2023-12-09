using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling c = new Cycling(30, 5);
        Running r = new Running(45, 4);
        Swimming s = new Swimming(20, 3);
        List<Activity> activities = new List<Activity>()
        {
            c,r,s
        };

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}