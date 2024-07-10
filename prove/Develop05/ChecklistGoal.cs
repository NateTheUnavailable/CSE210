public class ChecklistGoal : Goal
{
    private List<Task> tasks;
    public int PointsPerCompletion { get; set; }
    public int TotalCompletions { get; set; }
    public int BonusPoints { get; set; }
    public override int Points { get; set; }


    public ChecklistGoal(string description, List<Task> tasks, int pointsPerCompletion, int totalCompletions, int bonusPoints)
    {
        Description = description;
        this.tasks = tasks;
        PointsPerCompletion = pointsPerCompletion;
        TotalCompletions = totalCompletions;
        BonusPoints = bonusPoints;
    }

    public override void Achieve()
    {
        int completedTasks = tasks.Count(task => task.Completed);
        if (completedTasks < TotalCompletions)
        {
            Console.WriteLine($"Checklist goal {Description} recorded.");
            Console.WriteLine($"You gained {PointsPerCompletion} points.");
        }
        else
        {
            Console.WriteLine($"Checklist goal {Description} completed!");
            Console.WriteLine($"You gained {PointsPerCompletion} points and a bonus of {BonusPoints} points.");
        }
    }
}