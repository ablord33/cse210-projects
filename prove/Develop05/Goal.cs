public abstract class Goal
{
    public string Name { get; }
    public int Value { get; protected set; }
    public bool IsComplete { get; protected set; }

    protected Goal(string name)
    {
        Name = name;
        Value = 0;
        IsComplete = false;
    }

    public abstract void Complete();

    public string GetProgress()
    {
        return IsComplete ? "[X]" : "[ ]";
    }
}
