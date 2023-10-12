public class Entry
{

    public string _prompt;
    public string _response;
    public string _dateTime;

    public Entry(string prompt, string response, string dateTime)
    {
        _prompt = prompt;
        _response = response;
        _dateTime = dateTime;

   }

    public void DisplayEntry()
    {   

        Console.WriteLine("--------------------------");
        Console.WriteLine(_dateTime);
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Resppnse: {_response}");
        Console.WriteLine("--------------------------");
    }

    public string ConvertEntry()
    {
        return $"{_prompt},{_response},{_dateTime}";
    }
}