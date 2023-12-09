public class Reception : Event
{
    private string _email;
    
    
    
    public Reception(string title, string description, string date, string time, Address address,string eventType, string email) :base(title, description, date, time, address, eventType)
    {
        _email = email;
    }

    public void DisplayRecptionDetials()
    {
        Console.WriteLine($"Please RSVP at {_email}");
        Console.WriteLine($"This is a {_eventType} Event");

    }
}
