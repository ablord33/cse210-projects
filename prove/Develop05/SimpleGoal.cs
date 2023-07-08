public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public SimpleGoal(string name, int value, bool isComplete) : this(name, value)
    {
    }

    public override void Complete()
    {
        if (!IsComplete)
        {
            Value += 1000;
            IsComplete = true;
        }
    }

    public override string Display()
    {
        return $"Simple Goal: {Name}, Value: {Value}";
    }
}
