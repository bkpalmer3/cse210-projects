public class GoalMenu : Menu
{
    private string _goalMenu = "The types of goals are: \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal";

    public GoalMenu()
    {

    }

    public override void DisplayMenu()
    {
        Console.WriteLine("Which goal would you like to create? ");
        Console.WriteLine();
        Console.WriteLine(_goalMenu);
        Console.WriteLine();
        Console.Write("Please select a choice from the menu: ");
    }

}