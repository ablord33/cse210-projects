using System;

class Program
{
    public string _userChoice = "";
    public string _userFilename = "";

    public void GetUserInput()
    {
        Console.WriteLine("Enter 'a' to add an entry, 'v' to view all entries, or 'q' to quit:");
        _userChoice = Console.ReadLine();

        if (_userChoice == "a")
        {
            Console.WriteLine("Enter the filename for the entry:");
            _userFilename = Console.ReadLine();
        }
    }

    public void Run()
    {
        Journal journal = new Journal();
        if (_userChoice == "a")
        {
            journal.AddEntry(_userFilename);
        }
        else if (_userChoice == "v")
        {
            journal.Display();
        }
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.GetUserInput();
        program.Run();
    }
}
class Entry
{
    public DateTime _date;
    public string[] _prompts = {"What was the happiest moment of your day?", 
        "What was the worst thing that happened today?", "What are you grateful for today?", 
        "What made you feel sad today?", "What are some good news you heard today?"};
    public string _message = "";

    public void Write()
    {
        _date = DateTime.Now;
        for (int i = 0; i < _prompts.Length; i++)
        {
            Console.WriteLine(_prompts[i]);
            _message += Console.ReadLine() + "\n";
        }
    }

    public override string ToString()
    {
        string output = "Date: " + _date + "\n";
        for (int i = 0; i < _prompts.Length; i++)
        {
            output += _prompts[i] + "\n" + _message.Split('\n')[i] + "\n";
        }
        return output;
    }
}
class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private string _journalDirectory = @"C:\Journal\";

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("Date: " + entry._date);
            Console.WriteLine(entry._message);
        }
    }

    public List<Entry> Load()
    {
        // implement loading from a file
        return null;
    }

    public void Save()
    {
        // implement saving to a file
    }

    public void AddEntry(string filename)
    {
        Entry entry = new Entry();
        entry.Write();
        string filePath = _journalDirectory + filename + ".txt";
        Directory.CreateDirectory(_journalDirectory);
        File.WriteAllText(filePath, entry.ToString());
    }
}
