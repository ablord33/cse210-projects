public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public EternalGoal(string name, int value, bool isComplete) : this(name, value)
    {
    }

    public override void Complete()
    {
        Value += 100;
    }

    public override string Display()
    {
        return $"Eternal Goal: {Name}, Value: {Value}";
    }
}
