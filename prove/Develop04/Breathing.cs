public class Breathing : Activities
{

    public Breathing(string name, string description):base(name, description)
    {
        _name = name;
        _description = description;

    }

    // public void RunBreathing()
    // {
    //     Console.WriteLine(_name);
    //     Console.WriteLine(_description);
    //     Console.WriteLine();
    //     DateTime startTime = DateTime.Now;
    //     DateTime endTime = startTime.AddSeconds(_timeLength);
    //     Console.WriteLine("Get Ready!");
    //     Console.WriteLine();

    //     while (DateTime.Now < endTime )
    //     {
    //         Console.Write("Breath in...");
    //         for (int i = 6; i>0; i--)
    //         {
    //             Console.Write(i);
    //             Thread.Sleep(1000);
    //             Console.Write("\b \b");
    //         }
    //         Console.WriteLine();
    //         Console.WriteLine();

    //         Console.Write("Breath out...");
    //         for (int i = 4; i>0; i--)
    //         {
    //             Console.Write(i);
    //             Thread.Sleep(1000);
    //             Console.Write("\b \b");
    //         }
    //         Console.WriteLine();            
    //         Console.WriteLine();
    //     }

    //     Console.WriteLine($"{_endMessage}");
    //     Console.WriteLine();
    // }

}