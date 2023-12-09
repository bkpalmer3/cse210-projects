using System.Runtime.CompilerServices;

public class Activity 
{
    protected int _length; //in minutes
    protected string _date = DateTime.Now.ToShortDateString();

    public Activity(int length)
    {
        _length = length;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }   

    public virtual double CalculatePace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return " ";
    }
}