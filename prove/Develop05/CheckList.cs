using System.Data;
using System.Drawing;
using System.Xml.Schema;

public class CheckList : Goal
{
    private int _bigScore;
    private int _goalAmount;
    private int _actualAmount;
    private bool _isComplete = false;

    public CheckList()
    {

    }

    public CheckList(string name, string description, int pointAmount, int bigScore, int goalAmount) :base(name, description, pointAmount)
    {
        _bigScore = bigScore;
        _goalAmount = goalAmount;
        _actualAmount = 0;
    }
    public CheckList(string name, string description, int pointAmount, int bigScore, int goalAmount, int actualAmount, bool isComplete) :base(name, description, pointAmount)
    {
        _bigScore = bigScore;
        _goalAmount = goalAmount;
        _actualAmount = actualAmount;
        _isComplete = isComplete;
    }
    // Getters and Setters
    public void SetBigScore(int bigScore)
    {   
        _bigScore = bigScore;
    }
    public int GetBigScore()
    {
        return _bigScore;
    }

    public void SetGoalAmount(int goalAmount)
    {
        _goalAmount = goalAmount;
    }

    public int GetGoalAmount()
    {
        return _goalAmount;
    }

    public void SetActualAmount(int actualAmount)
    {
        _actualAmount = actualAmount;
    }

    public int GetActualAmount()
    {
        return _actualAmount;
    }

    public override void DisplayGoal()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($"    [x] {_name} -- Currently Completed {_actualAmount}/{_goalAmount}");
        }
        else
        {
            Console.WriteLine($"    [ ] {_name} -- Currently Completed {_actualAmount}/{_goalAmount}");
        }
    }
        public override string Stringify()
    {
        return $"CheckList:{_name},{_description},{_pointAmount},{_bigScore},{_goalAmount},{_actualAmount},{_isComplete}";
    }

    public override int CompleteGoal()
    {
        _actualAmount = _actualAmount + 1;
        
        if (_actualAmount == _goalAmount)
        {
            _isComplete = true;
            return _bigScore;
        }
        else
        {
            return 0;
        }
    }
    // public override void Record()
    // {
    //     _score = _score + _pointAmount;
    //     _actualAmount = _actualAmount + 1;

    //     if (_actualAmount == _goalAmount)
    //     {
    //         _score = _score + _bigScore;
    //     }
    // }

}

