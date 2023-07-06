public class EternalGoal : Goal
{
    public EternalGoal(string name) : base(name)
    {
    }

    public override void Complete()
    {
        Value += 100;
    }
}
