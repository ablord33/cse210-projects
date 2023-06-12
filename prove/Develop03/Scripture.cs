using System;
using System.Collections.Generic;

class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;

    public Reference Reference => _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordStrings = text.Split(' ');
        foreach (string wordString in wordStrings)
        {
            _words.Add(new Word(wordString));
        }
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public void HideRandomWords(Random random)
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                if (random.Next(2) == 0) // Hide 50% of the words
                {
                    word.Hide();
                }
            }
        }
    }

    public bool HasHiddenWords()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
                return true;
        }
        return false;
    }

    internal void HideRandomWords()
    {
        throw new NotImplementedException();
    }
}
