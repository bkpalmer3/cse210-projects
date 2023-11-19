public class Word
{   
    private string _singleWord;
    private bool _hidden;

    public Word(string word)
    {
        _singleWord = word;
        _hidden = false;
    }

    public void DisplayWord()
    {
        Console.Write($"{_singleWord} ");
    }

    public void HideWord()
    {
        _singleWord = "___";
        _hidden = true;
    }
    public bool GetHidden()
    {
        return _hidden;
    }
}