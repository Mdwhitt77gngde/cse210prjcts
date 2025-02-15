public class ChecklistGoal : Goal
{
    private int target;
    private int completedCount = 0;
    public ChecklistGoal(string name, int points, int target)
    {
        Name = name;
        Points = points;
        this.target = target;
    }
    public override void RecordEvent()
    {
        if (completedCount < target)
        {
            completedCount++;
        }
    }
    public override bool IsComplete() => completedCount >= target;
    public override string GetStatus() => $"{Name}: {completedCount}/{target} completions";
}
