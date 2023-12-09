using System;

class Program
{
    static void Main(string[] args)
    {
        Event baseEvent = new Event();
        Address lectureAddress = new Address("123 Bakers Street", "Rexburg", "Idaho", "USA");
        Lecture lectureEvent = new Lecture("Brother Hayes Sermon on coding", "Brother Hayes of Byui will be providing information on how we can code better.", "12-11-23", "9:00 AM", lectureAddress, "Lecture", "Adam Hayes", 100);
        Address receptionAddress = new Address("555 Reception way", "San Diego", "California", "USA");
        Reception receptionEvent = new Reception("Wedding of Matthew and Kate", "The marraige of Matthew Pantry and Kate Loveland", "12-15-25", "6:00 PM", receptionAddress, "Reception", "Matt.Kay@email.com");
        Address outdoorGatheringAddress = new Address("505 Middle da woods way", "Denver", "Colorado", "USA");
        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering("Search for Bigfoot", "Join us as we search the woods for bigfoot in order to find his location, snacks will be provided", "1-2-24", "3:00AM", outdoorGatheringAddress, "Ourdoor Gathering", "Stormy");

        Console.WriteLine("Details for the Events: ");
        Console.WriteLine("====================================");  
        lectureEvent.DisplayStandardDetail();
        Console.WriteLine("====================================");
        receptionEvent.DisplayStandardDetail();
        Console.WriteLine("====================================");
        outdoorGatheringEvent.DisplayStandardDetail();
        Console.WriteLine();

        Console.WriteLine("Full details for the Events: ");
        Console.WriteLine("====================================");
        lectureEvent.DisplayStandardDetail();
        lectureEvent.LectureDetials();
        Console.WriteLine("====================================");
        receptionEvent.DisplayStandardDetail();
        receptionEvent.DisplayRecptionDetials();
        Console.WriteLine("====================================");
        outdoorGatheringEvent.DisplayStandardDetail();
        outdoorGatheringEvent.DisplayWeatherDetails();
        Console.WriteLine();

        Console.WriteLine("Short decscription for the Events: ");
        Console.WriteLine("====================================");
        lectureEvent.DisplayShortDescription();
        Console.WriteLine("====================================");
        receptionEvent.DisplayShortDescription();
        Console.WriteLine("====================================");
        outdoorGatheringEvent.DisplayShortDescription();
        Console.WriteLine();

    }
}