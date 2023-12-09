public class OutdoorGathering : Event
{

    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string eventType, string weather) :base(title, description, date, time, address, eventType)
    {
        _weather = weather;
    }

    public void DisplayWeatherDetails()
    {
        Console.WriteLine($"The weather for the event looks to be: {_weather}");
        Console.WriteLine($"This is a {_eventType} Event");

    }



}