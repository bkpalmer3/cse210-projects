public class Activities
{
    protected string _name;
    protected string _description;
    protected List<string> _animation = new List<string>()
    {
        "\\",
        "_",
        "/",
        "-",
    };

    protected int _timeLength;

    public Activities(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayActivity()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"--> {_description}");
    }

    public string InputTimeLengthUser()
    {
        Console.Write("How many seconds would you like to do this activity for? ");
        string userInput = Console.ReadLine();
        return userInput;

    }

    public void SetTimeLength(string userInput)
    {
        _timeLength = int.Parse(userInput);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Great Job! You have completed the {_name}");
    }

    public void RunAnimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        while (DateTime.Now < endTime )
        {
            foreach (string a in _animation)
            {
                Console.Write(a);
                Thread.Sleep(500);
                Console.Write("\b \b \b");
            }
        }
    }

    public int GetTimeLength()
    {
        return _timeLength;
    }

    // public void DisplayWelcomeMessage()
    // {
    //     Console.WriteLine();
    //     Console.WriteLine(_name);
    //     Console.WriteLine(_description);
    //     Console.WriteLine();
               
    // }


}

