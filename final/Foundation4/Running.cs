public class Running : Activity
{
    private double _distance;

    public Running(int length, double distance) :base(length)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double CalculatePace()
    {
        return _length / _distance;
    }

    // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

    public override string GetSummary()
    {
        return $"{_date} Running ({_length})- Distance {_distance} miles, Speed {Math.Round(CalculateSpeed(), 2)} mph Pace: {Math.Round(CalculatePace(), 2)} min per mile";
    }
}