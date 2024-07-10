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

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
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