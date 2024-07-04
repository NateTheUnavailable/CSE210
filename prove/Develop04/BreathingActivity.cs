public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }

    public void StartBreathingActivity()
    {
        StartActivity();
        Console.WriteLine("Start breathing...");
        while (breathing != 0)
        {
            Console.WriteLine("Breath in for 4 seconds");
            Thread.Sleep(4000);
            Console.WriteLine("Breath out for 4 seconds");
            Thread.Sleep(4000);
            breathing = breathing - 1;
        }
        EndActivity();
    }
}