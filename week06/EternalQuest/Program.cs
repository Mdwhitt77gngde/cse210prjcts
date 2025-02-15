class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        manager.AddGoal(new SimpleGoal { Name = "Run a marathon", Points = 100 });
        manager.AddGoal(new EternalGoal { Name = "Read daily", Points = 10 });
        manager.AddGoal(new ChecklistGoal("Exercise", 50, 5));

        while (true)
        {
            Console.WriteLine("1. Record goal event\n2. Show goals\n3. Exit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                manager.RecordGoal(name);
            }
            else if (choice == "2")
            {
                manager.DisplayGoals();
            }
            else break;
        }
    }
}
