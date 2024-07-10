public class EternalGoal : Goal
{
    public override int Points { get; set; }
    public override void Achieve()
    {
        Console.WriteLine("Eternal goal achieved: " + Description);
        Console.WriteLine($"You gained {Points} points.");
    }
}