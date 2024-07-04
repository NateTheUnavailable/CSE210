public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public int breathing;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_name} activity: {_description}");
        Console.Write("Enter duration in seconds: ");
        _duration = Convert.ToInt32(Console.ReadLine());
        breathing = _duration / 8;
        
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(1000); // Pause for 1 second
    }

    public void EndActivity()
    {
        Console.WriteLine($"You've done a good job!");
        Console.WriteLine($"Completed {_name} for {_duration} seconds.");
        Thread.Sleep(1000); // Pause for 1 second
    }
}