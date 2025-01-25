using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = 3; // Number of words to hide at a time

        for (int i = 0; i < wordsToHide; i++)
        {
            Word word;
            do
            {
                word = _words[random.Next(_words.Count)];
            }
            while (word.IsHidden);

            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }

    public string GetDisplayText()
    {
        string text = _reference.GetFormattedReference() + " - ";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text.Trim();
    }
}
