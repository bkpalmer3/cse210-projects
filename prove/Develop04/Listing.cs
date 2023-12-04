using System.Runtime.CompilerServices;

public class Listing : Activities
{
    private List<string> _prompts = new List<string>()
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    };
    private List<string> _answers = new List<string>();
    private int _numberOfItems;


public Listing(string name, string description):base(name, description)
{
    _name = name;
    _description = description;

}

public void AddAnswer(string answer)
{
    _answers.Add(answer);
}

public void SetNumberOfItems()
{
    int count = _answers.Count();
    _numberOfItems = count;
}

public void DisplayNumberOfItems()
{
    Console.WriteLine($"You wrote {_numberOfItems} items");
}

public string GetRandomPrompt()
{
    int count = _prompts.Count();
    Random randomGenerator = new Random();
    int index = randomGenerator.Next(0, count);
    return _prompts[index];
}
}