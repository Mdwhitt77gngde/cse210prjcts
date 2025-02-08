using System;
using System.Threading;

public class Activity
{
    protected void ShowStartMessage(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.WriteLine("Please enter the duration in seconds:");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Thread.Sleep(2000);
        StartCountdown(duration);
    }

    protected void ShowEndMessage(string activityName, int duration)
    {
        Console.WriteLine($"Good job! You have completed the {activityName}.");
        Console.WriteLine($"You spent {duration} seconds on this activity.");
        Thread.Sleep(2000);
    }

    protected void StartCountdown(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(".");  // Animation: period character
            Thread.Sleep(1000);  // Update every second
        }
    }
}
