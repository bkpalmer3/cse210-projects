public class Job 
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine ("---------------------------");
        Console.WriteLine ($"Job: {_jobTitle}");
        Console.WriteLine ($"Company: {_company}");
        Console.WriteLine ($"Start Year: {_startYear}");
        Console.WriteLine ($"End Year: {_endYear}");
        Console.WriteLine ("---------------------------");
    }
}