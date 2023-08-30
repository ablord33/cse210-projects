using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;
    private int score;
    private const string FileName = "goals.txt";

    public GoalManager()
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
            Console.WriteLine($"{i + 1}. {goal.Display()} {goal.Name} [{goal.GetProgress()}]");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void SaveGoalsToFile()
    {
        using (StreamWriter writer = new StreamWriter(FileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetType().FullName);
                writer.WriteLine(goal.Name);
                writer.WriteLine(goal.Value);
                writer.WriteLine(goal.IsComplete);
            }
        }
        Console.WriteLine("Goals saved to file.");
    }

    public void LoadGoalsFromFile()
    {
        goals.Clear();
        score = 0;

        if (!File.Exists(FileName))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        using (StreamReader reader = new StreamReader(FileName))
        {
            while (!reader.EndOfStream)
            {
                string typeName = reader.ReadLine();
                string name = reader.ReadLine();
                int value = int.Parse(reader.ReadLine());
                bool isComplete = bool.Parse(reader.ReadLine());

                Goal goal = CreateGoalInstance(typeName, name, value, isComplete);
                if (goal != null)
                {
                    goals.Add(goal);
                    score += goal.Value;
                }
            }
        }
        Console.WriteLine("Goals loaded from file.");
    }

    private Goal CreateGoalInstance(string typeName, string name, int value, bool isComplete)
    {
        switch (typeName)
        {
            case "SimpleGoal":
                return new SimpleGoal(name, value, isComplete);
            case "EternalGoal":
                return new EternalGoal(name, value, isComplete);
            case "ChecklistGoal":
                return new ChecklistGoal(name, value, isComplete);
            default:
                Console.WriteLine($"Invalid goal type: {typeName}");
                return null;
        }
    }

    public void ClearGoals()
    {
        goals.Clear();
        score = 0;
    }
}
