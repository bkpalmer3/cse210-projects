public class Event
{
    private string _title;
    private string _description;
    private string _date; //mm-dd-yyyy

    private string _time; //0:00 AM/PM

    protected string _eventType;
    private Address _address;

    public Event (string title, string description, string date, string time, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public Event()
    {
        
    }

    public void DisplayStandardDetail() //Lists the title, description, date, time, and address.
    {
        Console.WriteLine($"{_title}: ");
        Console.WriteLine(_description);
        Console.WriteLine($"This even will take place on {_date}");
        Console.WriteLine($"The event will start at {_time}");
        Console.Write($"The Event is located at ");
        Console.WriteLine(_address.StringifyAddress());
    }

    public void DisplayShortDescription() //Lists the type of event, title, and the date.
    {  
        Console.WriteLine($"This is a {_eventType} Event");
        Console.WriteLine(_title, _date);

    }

}