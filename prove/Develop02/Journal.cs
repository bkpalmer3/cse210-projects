public class Journal 
{
    public List<Entry> _entryList = new List<Entry>();

public Journal ()
{

}

public void AddEntry(Entry _newEntry)
{
    _entryList.Add(_newEntry);
}

public void DisplayJournal()
{
    Console.WriteLine("Entries:");
    foreach (Entry entry in _entryList)
    {
        entry.DisplayEntry();
    }
}

public void SaveJournal()
{
    using (StreamWriter outputFile = new StreamWriter("journal.txt"))
            {
                foreach (Entry entry in _entryList)
                {
                    outputFile.WriteLine(entry.ConvertEntry());
                }
            }
}

public void LoadJornal()
{
    string[] lines = System.IO.File.ReadAllLines("journal.txt");

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        string prompt = parts[0];
        string response = parts[1];
        string date = parts[2];

        Entry newEntry = new Entry(prompt, response, date);
        _entryList.Add(newEntry);
    }
}
}