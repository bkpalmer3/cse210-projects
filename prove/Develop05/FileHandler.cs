using System.Security.Cryptography.X509Certificates;

public class FileHandler
{
    private List<Goal> _goals = new List<Goal>();
    private int _scoreLoad;

    public FileHandler()
    {

    }

    public int GetScoreLoad()
    {
        return _scoreLoad;
    }
    public void AddGoal(Goal g)
    {
        _goals.Add(g);
    }

    public void ListGoals()
    {
        Console.WriteLine("Here are your current goals: ");
        Console.WriteLine();

        foreach (Goal goal in _goals)
        {
            goal.DisplayGoal();
        }
        
    }

    public Goal GetGoal(int index)
    {
        return _goals[index - 1];
    }
    public void SaveFiles(string fileName, int score)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            string scoreString = $"{score}";
            foreach (Goal goal in _goals)
            {
                string goalstring = goal.Stringify();
                outputFile.WriteLine($"{scoreString} {goalstring}");
            }
        }
    }

    public void LoadFiles(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string[] smallerParts = parts[1].Split(",");
            string[] scoreOnly = parts[0].Split(" ");
            string className = scoreOnly[1];
            string name = smallerParts[0];
            string description = smallerParts[1];

            _scoreLoad = int.Parse(scoreOnly[0]);
                        
            int pointAmount = int.Parse(smallerParts[2]);

                if (className == "Simple")
                {
                    bool isComplete = bool.Parse(smallerParts[3]);
                    Simple s = new Simple(name, description, pointAmount, isComplete);
                    _goals.Add(s);

                }
                else if (className == "Eternal")
                {
                    Eternal e = new Eternal(name, description, pointAmount);
                    _goals.Add(e);
                }
                else if (className == "CheckList")
                {
                    int bigScore = int.Parse(smallerParts[3]);
                    int goalAmount = int.Parse(smallerParts[4]);
                    int actualAmount = int.Parse(smallerParts[5]);
                    bool checkedOff = bool.Parse(smallerParts[6]);

                    CheckList cl = new CheckList(name, description, pointAmount, bigScore, goalAmount, actualAmount, checkedOff);
                    _goals.Add(cl);
                }

            

        }
    }
}
