public class SwimmingActivity : Activity
{
    private int _laps;

    // Constructor to initialize swimming activity with laps
    public SwimmingActivity(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // Override method to get the distance for swimming activity
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // Distance in kilometers
    }

    // Override method to get the speed for swimming activity
    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60; // Speed in kilometers per hour
    }

    // Override method to get the pace for swimming activity
    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    // Override method to get the summary information for swimming activity
    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{base.GetSummary()} Swimming - Distance {distance:F1} km, Speed {speed:F1} kph, Pace: {pace:F1} min per km";
    }
}
