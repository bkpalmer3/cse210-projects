public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(int length, int numberOfLaps) :base(length)
    {
        _numberOfLaps = numberOfLaps;
    }


    public override double CalculateDistance()
    {
        return (_numberOfLaps * 50) / (1000 * 0.62);
    }
    public override double CalculateSpeed()
    {
        return (CalculateDistance() / _length) * 60;
    }

    public override double CalculatePace()
    {
        return (60 / CalculateSpeed());
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length})- Distance {Math.Round(CalculateDistance(), 2)} miles, Speed {Math.Round(CalculateSpeed(), 2)} mph Pace: {Math.Round(CalculatePace(), 2)} min per mile";
    }
}