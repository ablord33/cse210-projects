using System;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void ExecuteActivity()
    {
        Random random = new Random();
        int count = 0;

        Console.WriteLine(prompts[random.Next(prompts.Length)]);
        Thread.Sleep(3000);
        Console.WriteLine("Begin listing:");

        DateTime startTime = DateTime.Now;
        while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
        {
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
                break;
            count++;
        }

        Console.WriteLine("You listed " + count + " item(s).");
    }
}
