using System.ComponentModel.DataAnnotations;

public class Menu
{
    private string _menu = "Menu Options: \n 1. Create new goal \n 2. List goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit";
    
    protected int _menuInput = 0;

    public Menu()
    {

    }

    // Getters and Setters
    public int GetMenuInput()
    {
        return _menuInput;
    }

    public void SetMenuInput(string menuInput)
    {
        int input = int.Parse(menuInput);
        _menuInput = input;
    }

    // Display
    public virtual void DisplayMenu()
    {
        Console.WriteLine(_menu);
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
    }

}