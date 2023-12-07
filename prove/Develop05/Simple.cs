public class Simple : Goal
{
    private bool _isComplete;

    public Simple()
    {

    }

    public Simple(string name, string description, int pointAmount) :base(name, description, pointAmount)
    {
        _isComplete = false;
    }

    public Simple(string name, string description, int pointAmount, bool isComplete) :base(name, description, pointAmount)
    {
        _isComplete = isComplete;
    }

    // Getters and Setters
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    
    public override void DisplayGoal()
    {
        if (_isComplete == false)
        {
            Console.WriteLine($"    [ ] {_name}");
        }
        else
        {
            Console.WriteLine($"    [x] {_name}");
        }
    }
    public override string Stringify()
    {
        return $"Simple:{_name},{_description},{_pointAmount},{_isComplete}";
    }

    public override int CompleteGoal()
    {
        _isComplete = true;
        return 0;
    }
    // public override void Record()
    // {
    //     _score = _score + _pointAmount;
    //     _isComplete = true;
    // }


}