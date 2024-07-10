using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goal Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter points for the goal: ");
                    int points = Convert.ToInt32(Console.ReadLine());
                    goalManager.AddGoal(description, points);
                    break;
                case 2:
                    goalManager.DisplayGoals();
                    break;
                case 3:
                    goalManager.SaveGoals("goals.json");
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case 4:
                    goalManager.LoadGoals("goals.json");
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case 5:
                    goalManager.DisplayGoals();
                    Console.Write("Enter the goal index to record an event: ");
                    int goalIndex = Convert.ToInt32(Console.ReadLine());
                    goalManager.RecordEvent(goalIndex - 1); // Subtract 1 to match index
                    break;
                case 6:
                    goalManager.DisplayScore();
                    break;
                case 7:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
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