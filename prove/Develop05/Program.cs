using System;
using System.Collections.Generic;
using System.IO;

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
            Console.WriteLine($"{i + 1}. {goal.Display()} {goal.Name}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void SaveGoalsToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
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

    public void LoadGoalsFromFile(string filename)
    {
        goals.Clear();
        score = 0;

        using (StreamReader reader = new StreamReader(filename))
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

    public static void Main(string[] args)
    {
        Program questProgram = new Program();

        // Create and add goals
        Goal goal1 = new SimpleGoal("Run a marathon", 1000);
        Goal goal2 = new EternalGoal("Read the scriptures", 100);
        Goal goal3 = new ChecklistGoal("Attend the temple", 50, 10);
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

        // Save goals to file
        questProgram.SaveGoalsToFile("goals.txt");

        // Clear goals
        questProgram.ClearGoals();

        // Load goals from file
        questProgram.LoadGoalsFromFile("goals.txt");

        // Display goals and score after loading from file
        questProgram.DisplayGoals();
        questProgram.DisplayScore();
    }

    public void ClearGoals()
    {
        goals.Clear();
        score = 0;
    }
}
