using System;

// Base class representing a fitness activity
public class Activity
{
    // Private member variables
    private DateTime _date;
    protected int _minutes; // Change access modifier to protected

    // Constructor to initialize date and minutes for an activity
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Virtual methods to be overridden in derived classes
    public virtual double GetDistance() => 0; // Default distance is 0 for general activities
    public virtual double GetSpeed() => 0; // Default speed is 0 for general activities
    public virtual double GetPace() => 0; // Default pace is 0 for general activities

    // Get the summary information for an activity
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} ({_minutes} min)";
    }
}
