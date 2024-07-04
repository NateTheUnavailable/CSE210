public class ListingActivity : Activity
{
    public ListingActivity(string name, string description) : base(name, description) { }

    public void StartListingActivity()
    {
        StartActivity();
        LoadingSpinner.ShowSpinner();
        string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Length);
        Console.WriteLine(prompts[randomIndex]);
        Thread.Sleep(5000);

        List<string> items = new List<string>();
        Console.WriteLine("Enter items for your list");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            items.Add(input);
        }

        Console.WriteLine("Your list:");
        foreach (var item in items)
        {
            Console.WriteLine("- " + item);
        }
        EndActivity();
    }
}