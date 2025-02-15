public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    public void AddGoal(Goal goal) => goals.Add(goal);
    public void RecordGoal(string name)
    {
        var goal = goals.FirstOrDefault(g => g.Name == name);
        goal?.RecordEvent();
    }
    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
    }
}