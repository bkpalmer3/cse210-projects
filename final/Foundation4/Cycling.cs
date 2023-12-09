public class Cycling : Activity
{
    private double _speed;


    public Cycling(int length, double speed) :base(length)
    {
        _speed = speed;
    }

// Speed (mph or kph) = (distance / minutes) * 60
    public override double CalculateDistance()
    {
        return (_speed / 60) * _length;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        
        return $"{_date} Cycling ({_length})- Distance {Math.Round(CalculateDistance(), 2)} miles, Speed {_speed} mph Pace: {Math.Round(CalculatePace(), 2)} min per mile";
    }
}