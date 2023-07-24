using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private readonly string _journalDirectory = @"C:\Journal\";
    private readonly string[] _prompts = {
        "What was the happiest moment of your day?",
        "What was the worst thing that happened today?",
        "What are you grateful for today?",
        "What made you feel sad today?",
        "What are some good news you heard today?"
    };
    private List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void AddEntry(string filename)
    {
        Entry entry = new Entry();
        Random rand = new Random();
        int randomIndex = rand.Next(0, _prompts.Length);
        entry.Write(_prompts[randomIndex]);

        string filePath = _journalDirectory + filename + ".txt";
        Directory.CreateDirectory(_journalDirectory);
        File.WriteAllText(filePath, entry.ToString());

        _entries.Add(entry);
    }
}
