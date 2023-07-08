public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completionCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name)
    {
        Value = value;
        _targetCount = targetCount;
        _completionCount = 0;
    }

    public ChecklistGoal(string name, int value, bool isComplete) : base(name)
    {
    }

    public override void Complete()
    {
        if (!IsComplete)
        {
            Value += 50;
            _completionCount++;
            if (_completionCount >= _targetCount)
            {
                Value += 500;
                IsComplete = true;
            }
        }
    }

    public override string Display()
    {
        return $"Checklist Goal: {Name}, Value: {Value}";
    }
}
