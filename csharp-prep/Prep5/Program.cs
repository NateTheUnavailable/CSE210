using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        double sq;
        Console.WriteLine("Welcome to the program!");
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your favorite number: ");
        string me = Console.ReadLine();
        num = int.Parse(me);
        sq = num * num;
        Console.WriteLine($"{name}, the square of your number is {sq}");
    }
}