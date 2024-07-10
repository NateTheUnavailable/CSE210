public class Goal
{
    public string Description { get; set; }
    public virtual int Points { get; set; } = 0;

    public virtual void Achieve()
    {
        Console.WriteLine("Goal achieved: " + Description);
    }
}
