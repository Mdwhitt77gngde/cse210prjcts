public class EternalGoal : Goal
{
    private int timesCompleted = 0;
    public override void RecordEvent()
    {
        timesCompleted++;
    }
    public override bool IsComplete() => false;
    public override string GetStatus() => $"{Name} completed {timesCompleted} times";
}
