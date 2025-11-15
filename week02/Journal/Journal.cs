using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

public class Journal
{
    //Notebook that stores all entries
    private List<Entry> _entries = new List<Entry>();

    //Method-Add a new entry tot the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    //Method-display all entries in the journal
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)

        {
            entry.Display();
        }
    }
    //Method: Save all entries to file
    public void saveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._dateTime}|{entry._prompt}|{entry._text}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear(); //clear existing entries
        
        string[] lines = File.ReadAllLines(filename); //read all line from the file
        
        foreach (string line in lines)
        {
            string[] parts = line.Split('|'); // split by the separator

            Entry newEntry = new Entry();
            newEntry._dateTime = parts[0];
            newEntry._prompt = parts[1];
            newEntry._text = parts[2];

            _entries.Add(newEntry);
        }
    }

}