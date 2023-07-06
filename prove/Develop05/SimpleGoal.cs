public class SimpleGoal : Goal
{
    public SimpleGoal(string name) : base(name)
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
}
