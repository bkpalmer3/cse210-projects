using System.Collections;
using System.Net.Quic;
using System.Runtime.InteropServices;

public class Verse
{
    private string _fullVerse;
    private List<Word> _wordList = new List<Word>();

    public Verse(string fullVerse)
    {
        _fullVerse = fullVerse;
    }

    public void BuildWordList()
    {
        string[] brokenList;
        brokenList = _fullVerse.Split(" ");
        foreach (string word in brokenList)
        {
            Word word1 = new Word(word);
            _wordList.Add(word1);
        }
    }
    public void DisplayVerse()
    {
        foreach (Word word in _wordList)
        {
            word.DisplayWord();
        }
    }
    public void RemoveWords()
    {
        int count = _wordList.Count();
        for (int i = 0; i < 5; i++)
        {
            Random randomNumber = new Random();
            int randomIndex = randomNumber.Next(0, count);

            bool hidden = _wordList[randomIndex].GetHidden();
            if (hidden == false)
            {
                _wordList[randomIndex].HideWord();
            }
            }
            
        }
    public bool CheckHidden()
    {
        bool allHidden = true;

        foreach (Word word in _wordList)
        {
            bool hidden = word.GetHidden();
            if (hidden == false)
            {
                allHidden = false;
                break;
            }
        }
        return allHidden;

    }    

    }
    
