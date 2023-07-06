public class ChecklistGoal : Goal
{
    private readonly int targetCount;
    private int completionCount;

    public ChecklistGoal(string name, int targetCount) : base(name)
    {
        this.targetCount = targetCount;
        completionCount = 0;
    }

    public override void Complete()
    {
        if (!IsComplete)
        {
            Value += 50;
            completionCount++;
            if (completionCount >= targetCount)
            {
                Value += 500;
                IsComplete = true;
            }
        }
    }
}
