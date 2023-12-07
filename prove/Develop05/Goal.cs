using System.Reflection.Metadata.Ecma335;

public class Goal
{
    protected string _name;
    protected string _description;
    // protected int _score;

    protected int _pointAmount;

    // Constructors
    public Goal()
    {
        // _score = 0;
    }

    public Goal(string name, string description, int pointAmount)
    {
        _name = name;
        _description = description;
        // _score = 0;
        _pointAmount = pointAmount;
    }


    // Getters and Settters
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    // public void SetScore(int score)
    // {
    //     _score = score;
    // }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    // public int GetScore()
    // {
    //     return _score;
    // }

    public int GetPointAmount()
    {
        return _pointAmount;
    }

    // Display
    // public void DisplayScore()
    // {
    //     Console.WriteLine($"You have {_score} points");
    //     Console.WriteLine();
    // }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name}");
    }

    public virtual string Stringify()
    {
        return $"Goal:{_name},{_description},{_pointAmount}";
    }

    public virtual int CompleteGoal()
    {
        return 0;
    }

    // public virtual void Record()
    // {
    //     _score = _score + _pointAmount;
    // }
}