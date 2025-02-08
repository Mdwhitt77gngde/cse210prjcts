using System;

public class ReflectionActivity : Activity
{
    public void StartActivity()
    {
        ShowStartMessage("Reflection Activity", 
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine(selectedPrompt);
        Thread.Sleep(3000);  // Wait before asking questions

        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?"
        };

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(3000);  // Simulate pause for reflection
        }

        ShowEndMessage("Reflection Activity", 20);  // Example duration of 20 seconds
    }
}
