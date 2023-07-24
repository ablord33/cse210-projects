using System;

class Entry
{
    public DateTime Date { get; private set; }
    public string Prompt { get; private set; }
    public string Message { get; private set; }

    public void Write(string prompt)
    {
        Date = DateTime.Now;
        Prompt = prompt;
        Console.WriteLine(Prompt);
        Message = Console.ReadLine();
    }

    public override string ToString()
    {
        return "Date: " + Date + "\n" + Prompt + "\n" + Message + "\n";
    }
}
