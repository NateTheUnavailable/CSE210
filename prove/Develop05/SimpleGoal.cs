public class SimpleGoal : Goal
{
    public bool IsComplete { get; set; }
    public override int Points { get; set; }

    public override void Achieve()
    {
        if (!IsComplete)
        {
            Console.WriteLine("Simple goal achieved: " + Description);
            Console.WriteLine($"You gained {Points} points.");
        }
        else
        {
            Console.WriteLine("Simple goal already completed: " + Description);
        }
    }
}