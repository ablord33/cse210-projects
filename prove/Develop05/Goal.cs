public abstract class Goal
{
    private string _name;
    public string Name
    {
        get { return _name; }
        protected set { _name = value; }
    }

    private int _value;
    public int Value
    {
        get { return _value; }
        protected set { _value = value; }
    }

    private bool _isComplete;
    public bool IsComplete
    {
        get { return _isComplete; }
        protected set { _isComplete = value; }
    }

    protected Goal(string name)
    {
        _name = name;
        _value = 0;
        _isComplete = false;
    }

    public abstract void Complete();

    public string GetProgress()
    {
        return IsComplete ? "[X]" : "[ ]";
    }

    public abstract string Display();
}
