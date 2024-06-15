using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,20);
        int me = 0;
        while (me != number)
        {
            string response;
            Console.WriteLine("What is your guess?");
            response = Console.ReadLine();
            me = int.Parse(response);
            if (me > number)
            {
                Console.WriteLine("Lower");
            }
            else if (me < number)
            {
                Console.WriteLine("Higher");
            }
            else if (me == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("That is not a number");
            }
        }
    }
}