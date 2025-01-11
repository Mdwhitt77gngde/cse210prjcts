using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "c";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}