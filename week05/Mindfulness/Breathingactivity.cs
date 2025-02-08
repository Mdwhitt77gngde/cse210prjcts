using System;

public class BreathingActivity : Activity
{
    public void StartActivity()
    {
        ShowStartMessage("Breathing Activity", 
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        
        Console.WriteLine("Breathe in...");
        Thread.Sleep(4000);  // Simulate breathing in
        Console.WriteLine("Breathe out...");
        Thread.Sleep(4000);  // Simulate breathing out

        ShowEndMessage("Breathing Activity", 10);  // Example duration of 10 seconds
    }
}
