using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Instances setup
        Menu m = new Menu();
        GoalMenu gm = new GoalMenu();
        Goal g = new Goal();
        FileHandler f = new FileHandler();
        User u = new User();



        while (m.GetMenuInput() != 6)
        {
            int scoreLoad = f.GetScoreLoad();
            u.UpdateScore(scoreLoad);
            
            //Menu Display
            Console.Clear();
            u.DisplayScore();
            Console.WriteLine();

            m.DisplayMenu();
            string menuInput = Console.ReadLine();
            m.SetMenuInput(menuInput);

            switch (m.GetMenuInput())
            {
                case 1:
                    Console.Clear();
                    gm.DisplayMenu();
                    string input = Console.ReadLine();
                    gm.SetMenuInput(input);
                    switch (gm.GetMenuInput())
                    {
                        case 1:
                            Console.Write("Please provide a name for the goal: ");
                            string name = Console.ReadLine();
                            Console.Write("Please give a short description of your goal: ");
                            string description = Console.ReadLine();
                            Console.Write("How many points is this goal worth? ");
                            string uInput = Console.ReadLine();
                            int pointAmount = int.Parse(uInput);
                            Simple s = new Simple(name, description, pointAmount);

                            f.AddGoal(s);

                            Console.WriteLine();
                            Console.WriteLine("The New goal has been created!");
                            Console.Write("Press enter to return to the menu");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Please provide a name for the goal: ");
                            name = Console.ReadLine();
                            Console.Write("Please give a short description of your goal: ");
                            description = Console.ReadLine();
                            Console.Write("How many points is this goal worth? ");
                            uInput = Console.ReadLine();
                            pointAmount = int.Parse(uInput);
                            Eternal e = new Eternal(name, description, pointAmount);

                            f.AddGoal(e);

                            Console.WriteLine();
                            Console.WriteLine("The New goal has been created!");
                            Console.Write("Press enter to return to the menu");
                            Console.ReadLine();
                            break;

                        case 3:

                            Console.Write("Please provide a name for the goal: ");
                            name = Console.ReadLine();
                            Console.Write("Please give a short description of your goal: ");
                            description = Console.ReadLine();
                            Console.Write("How many points is this goal worth? ");
                            uInput = Console.ReadLine();
                            pointAmount = int.Parse(uInput);
                            Console.Write("How many times does this goal need to completed for a bonus? ");
                            uInput = Console.ReadLine();
                            int goalAmount = int.Parse(uInput);
                            Console.Write("What is the bonus for completing the entire goal? ");
                            uInput = Console.ReadLine();
                            int bigScore = int.Parse(uInput);
                        
                            CheckList cl = new CheckList(name, description, pointAmount, bigScore, goalAmount);

                            f.AddGoal(cl);

                            Console.WriteLine();
                            Console.Write("Press enter to return to the menu");
                            Console.ReadLine();
                            break;



                        
                    }

                    break;

                case 2:

                    Console.Clear();
                    f.ListGoals();
                    Console.WriteLine();
                    Console.Write("Press enter to return to the menu");
                    Console.ReadLine();

                break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("File save:");
                    Console.WriteLine();
                    Console.Write("What would you like to name the file? ");
                    f.SaveFiles(Console.ReadLine(), u.GetScore());
                    Console.WriteLine("Your file has been saved");
                    Console.Write("Press enter to return to the menu");
                    Console.ReadLine();

                break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("File Load:");
                    Console.WriteLine();
                    Console.Write("What is the name of the file you wish to Load? ");

                    f.LoadFiles(Console.ReadLine());
                    Console.WriteLine("Your file has been loaded");
                    Console.Write("Press enter to return to the menu");
                    Console.ReadLine();
                break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Which goal did you acomplish?");
                    Console.WriteLine();
                    f.ListGoals();
                    Console.WriteLine();

                    Console.Write("Please select a choice from the list: ");
                    Goal goal = f.GetGoal(int.Parse(Console.ReadLine()));
                    int bonus = goal.CompleteGoal();
                    u.UpdateScore(bonus);
                    int points = goal.GetPointAmount();
                    u.UpdateScore(points);

                    
                    Console.WriteLine("Your goal has been recorded");
                    Console.WriteLine($"Congratulations! You have been awarded {points + bonus}");
                    Console.Write("Press enter to return to the menu");
                    Console.ReadLine();


                    

                break;

            }
        }

    }
}