using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        UserInputHandler userInputHandler = new UserInputHandler(goalManager);

        // Create and add some default goals (optional)
        Goal goal1 = new SimpleGoal("Run a marathon", 1000);
        Goal goal2 = new EternalGoal("Read the scriptures", 100);
        Goal goal3 = new ChecklistGoal("Attend the temple", 50, 10);
        goalManager.AddGoal(goal1);
        goalManager.AddGoal(goal2);
        goalManager.AddGoal(goal3);

        userInputHandler.Start();
    }
}
