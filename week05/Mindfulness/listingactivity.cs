using System;

public class ListingActivity : Activity
{
    public void StartActivity()
    {
        ShowStartMessage("Listing Activity", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine(selectedPrompt);
        Thread.Sleep(2000);  // Give some time to think

        Console.WriteLine("Start listing now...");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(20);  // Duration of 20 seconds

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter an item (or leave empty to stop):");
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput)) break;
        }

        ShowEndMessage("Listing Activity", 20);  // Example duration of 20 seconds
    }
}
