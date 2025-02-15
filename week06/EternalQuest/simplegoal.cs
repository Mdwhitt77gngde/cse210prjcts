public class SimpleGoal : Goal
{
    private bool completed = false;
    public override void RecordEvent()
    {
        if (!completed)
        {
            completed = true;
        }
    }
    public override bool IsComplete() => completed;
    public override string GetStatus() => completed ? "[X] " + Name : "[ ] " + Name;
}