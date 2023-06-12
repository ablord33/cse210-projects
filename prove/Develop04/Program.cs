using System;

public class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=== MINDFULNESS APP ===");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("0. Quit");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            MindfulnessActivity activity;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    continue;
            }

            activity.StartActivity();
        }
    }
}