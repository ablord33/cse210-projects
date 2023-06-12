using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int duration;
    protected string name;
    protected string description;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine("=== " + name + " ===");
        Console.WriteLine(description);
        Console.WriteLine("Please enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
        Console.WriteLine();

        ExecuteActivity();

        Console.WriteLine("Good job! You have completed the " + name + ".");
        Thread.Sleep(3000);
        Console.WriteLine();
    }

    protected abstract void ExecuteActivity();
}
