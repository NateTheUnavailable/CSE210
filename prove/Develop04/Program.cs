using System;
using System.Threading;

public class MindfulnessProgram
{
    static void Main()
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "Focus on deep breathing.");
        ListingActivity listingActivity = new ListingActivity("Listing", "List things you are grateful for.");
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "Reflect on your day.");

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflecting");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    LoadingSpinner.ShowSpinner();
                    breathingActivity.StartBreathingActivity();
                    break;
                case 2:
                    LoadingSpinner.ShowSpinner();
                    listingActivity.StartListingActivity();
                    break;
                case 3:
                    LoadingSpinner.ShowSpinner();
                    reflectingActivity.StartReflectingActivity();
                    break;
                case 4:
                    isRunning = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
public class LoadingSpinner
{
    public static void ShowSpinner()
    {
        Console.Write("Loading ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("/");
            Thread.Sleep(100); // 0.2-second delay
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("-");
            Thread.Sleep(100); // 0.2-second delay
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("\\");
            Thread.Sleep(100); // 0.2-second delay
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("|");
            Thread.Sleep(100); // 0.2-second delay
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.WriteLine();
    }
}