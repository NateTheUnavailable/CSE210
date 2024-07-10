public class Goal
{
    public string Description { get; set; }
    public int Points { get; internal set; }

    public virtual void Achieve()
    {
        Console.WriteLine("Goal achieved: " + Description);
    }
}
