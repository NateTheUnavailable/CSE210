using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int me = int.Parse(answer);
        string letter = "";
       if (me >= 90)
        {
            letter = "A";
        }
        else if (me >= 80)
        {
            letter = "B";
        }
        else if (me >= 70)
        {
            letter = "C";
        }
        else if (me >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your Grade Is {letter}");
        if (me >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}