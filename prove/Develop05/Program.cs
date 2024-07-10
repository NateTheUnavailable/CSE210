using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();

        // Create sample goals
        var simpleGoal = new SimpleGoal { Description = "Run a marathon", Points = 1000 };
        var eternalGoal = new EternalGoal { Description = "Read scriptures", Points = 100 };
        var checklistGoal = new ChecklistGoal("Attend the temple", new List<Task>(), 50, 10, 500);

        goalManager.AddGoal(simpleGoal);
        goalManager.AddGoal(eternalGoal);
        goalManager.AddGoal(checklistGoal);

        goalManager.DisplayGoals();

        goalManager.RecordEvent(0); // Achieve simple goal
        goalManager.RecordEvent(1); // Achieve eternal goal
        goalManager.RecordEvent(2); // Record attendance for checklist goal

        goalManager.DisplayScore();

        goalManager.SaveGoals("goals.json");
        goalManager.LoadGoals("goals.json");
    }
}
public class Task
{
    public string Name { get; set; }
    public bool Completed { get; set; }

    public Task(string name, bool completed)
    {
        Name = name;
        Completed = completed;
    }
}