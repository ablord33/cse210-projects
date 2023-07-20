using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity and add them to the list
        activities.Add(new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new RunningActivity(new DateTime(2022, 11, 3), 30, 4.8));
        activities.Add(new CyclingActivity(new DateTime(2022, 11, 3), 45, 15.0));
        activities.Add(new SwimmingActivity(new DateTime(2022, 11, 3), 45, 30));

        // Display the summary information for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
