public class ReflectingActivity : Activity
{
    public ReflectingActivity(string name, string description) : base(name, description) { }

    public void StartReflectingActivity()
    {
        StartActivity();
        LoadingSpinner.ShowSpinner();
        string[] prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        string[] prompts2 = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Length);
        Console.WriteLine(prompts[randomIndex]);
        Thread.Sleep(5000);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Random rand2 = new Random();
            int randomIndex2 = rand2.Next(prompts.Length);
            Console.WriteLine(prompts2[randomIndex2]);
            Console.WriteLine("");
            string input = Console.ReadLine();
            items.Add(input);
        }
        EndActivity();
    }
}