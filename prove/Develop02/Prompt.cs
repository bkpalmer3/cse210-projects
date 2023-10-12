public class Prompt
{
    //Lists <strings> This will contain the list of all the prompts
    //Attributes
    public List<string> _promptList = new List<string>()
    {
        "How have you seen the hand of the Lord in your life today?",
        "What is one thing about your day that you want to remember?",
        "What was the hardest part about today and what did you learn?",
        "Who are you grateful for today?",
        "What is a funny experience you had today?",
    };

    //Class contructor
    public Prompt()
    {
        
    }

    //A method is needed to deterime a random prompt in the list by the index
    //Methods

    public string GetPrompt ()
    {
        Random randomPromtIndex = new Random();
        int index = randomPromtIndex.Next (0,5);
        string prompt = _promptList[index];
        
        return prompt;
        
    }


}  
