public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
}