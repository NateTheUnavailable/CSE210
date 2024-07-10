using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class GoalManager
{
    private List<Goal> goals;
    private int userScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        userScore = 0;
    }

    public void AddGoal(string description, int points)
    {
        Console.WriteLine("Select goal type (1 - Simple, 2 - Eternal, 3 - Checklist):");
        int type = Convert.ToInt32(Console.ReadLine());

        Goal goal;
        switch (type)
        {
            case 1:
                goal = new SimpleGoal { Description = description, Points = points };
                break;
            case 2:
                goal = new EternalGoal { Description = description, Points = points };
                break;
            case 3:
                goal = new ChecklistGoal(description, new List<Task>(), points, 0, 0);
                break;
            default:
                Console.WriteLine("Invalid goal type. Adding as a Simple goal.");
                goal = new SimpleGoal { Description = description, Points = points };
                break;
        }

        goals.Add(goal);
        Console.WriteLine("Goal added successfully.");
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.Achieve();
            userScore += goal.Points;
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"Goal {i + 1}: [{(goals[i] is ChecklistGoal checklistGoal ? $"Completed {checklistGoal.TotalCompletions}/{checklistGoal.TotalCompletions} times" : goals[i] is SimpleGoal simpleGoal && simpleGoal.IsComplete ? "X" : " ")}] - {goals[i].Description}\n");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {userScore} points.");
    }

    public void SaveGoals(string fileName)
    {
        string json = JsonSerializer.Serialize(goals);
        File.WriteAllText(fileName, json);
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            goals = JsonSerializer.Deserialize<List<Goal>>(json);
        }
    }
}