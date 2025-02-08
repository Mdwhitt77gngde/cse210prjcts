using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create instances of activities
        var breathingActivity = new BreathingActivity();
        var reflectionActivity = new ReflectionActivity();
        var listingActivity = new ListingActivity();

        // Menu to choose an activity
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!\n");
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathingActivity.StartActivity();
                    break;
                case "2":
                    reflectionActivity.StartActivity();
                    break;
                case "3":
                    listingActivity.StartActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
