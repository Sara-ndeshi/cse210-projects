using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] wordArray = text.Split(' '); // split text into words
        foreach (string w in wordArray)
        {
            _words.Add(new Word(w));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.ToString());
        foreach (Word w in _words)
        {
            Console.Write(w.Display() + " ");
        }
        Console.WriteLine("\n");
    }

    public void HideRandomWords(int count)
    {
        int hiddenCount = 0;
        Random random = new Random();
        
        // Get indices of words that are not hidden
    List<int> unhiddenIndices = new List<int>();
    for (int i = 0; i < _words.Count; i++)
    {
        if (!_words[i].IsHidden())
            unhiddenIndices.Add(i);
    }

    while (hiddenCount < count && unhiddenIndices.Count > 0)
    {
        int index = random.Next(unhiddenIndices.Count);
        _words[unhiddenIndices[index]].Hide();

        unhiddenIndices.RemoveAt(index);
        hiddenCount++;
    }
    }

    public bool AllWordsHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }

    public int GetHiddenWordCount()
    {
        int count = 0;
        foreach (Word w in _words)
        {
            if (w.IsHidden())
                count++;
        }
        return count;
    }
    public int TotalWordCount()
    {
        return _words.Count;
    }
}
