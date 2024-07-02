using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Bob The Builder", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        MathAssignment a2 = new MathAssignment("Rob The Robber", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Writing a3 = new Writing("Jack Sparrow", "History", "The Golden Age of Piracy");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}