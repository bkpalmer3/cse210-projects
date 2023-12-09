public class Lecture : Event
{
    private string _speaker;
    private int _capacity;


    public Lecture(string title, string description, string date, string time, Address address, string eventType, string speaker, int capacity) :base(title, description, date, time, address, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void LectureDetials()
    {
        Console.WriteLine($"Speaking at this even will be: {_speaker}");
        Console.WriteLine($"There will be room for {_capacity} people");
        Console.WriteLine($"This is a {_eventType} Event");
    }
}