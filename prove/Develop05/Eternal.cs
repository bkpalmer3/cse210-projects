public class Eternal : Goal
{
    public Eternal()
    {

    }

    public Eternal(string name, string description, int pointAmount) :base(name, description, pointAmount)
    {

    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"    [∞] {_name}");
    }

        public override string Stringify()
    {
        return $"Eternal:{_name},{_description},{_pointAmount},";
    }


}