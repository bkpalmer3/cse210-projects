public class Menu
{
    private string _menu = "Menu:\n 1. Start Breathing Activity\n 2. Start Reflecting Activity\n 3. Start listing Activity\n 4. Quit";
    private int _userInput;

    public Menu()
    {

    }

    public void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine(_menu);
    }

    public int EnterUserInput()
    {
        Console.Write("Set a choice from the menu: ");
        string stringInput = Console.ReadLine();
        _userInput = int.Parse(stringInput);
        return _userInput;
    }
}