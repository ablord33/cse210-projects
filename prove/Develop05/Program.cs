using System;
using System.Collections.Generic;

public class Program
{
    private List<Goal> goals;
    private int score;

    public Program()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.Complete();
            score += goal.Value;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetProgress()} {goal.Name}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public static void Main(string[] args)
    {
        Program questProgram = new Program();

        // Create and add goals
        Goal goal1 = new SimpleGoal("Run a marathon");
        Goal goal2 = new EternalGoal("Read the scriptures");
        Goal goal3 = new ChecklistGoal("Attend the temple", 10);
        questProgram.AddGoal(goal1);
        questProgram.AddGoal(goal2);
        questProgram.AddGoal(goal3);

        // Simulate completing goals
        questProgram.RecordEvent(0); // Completes goal1 (Run a marathon)
        questProgram.RecordEvent(1); // Completes one occurrence of goal2 (Read the scriptures)
        questProgram.RecordEvent(2); // Completes one occurrence of goal3 (Attend the temple)

        // Display goals and score
        questProgram.DisplayGoals();
        questProgram.DisplayScore();
    }
}
