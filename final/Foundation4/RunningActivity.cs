public class RunningActivity : Activity
{
    private double _distance;

    // Constructor to initialize running activity with distance
    public RunningActivity(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // Override method to get the distance for running activity
    public override double GetDistance()
    {
        return _distance;
    }

    // Override method to get the speed for running activity
    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    // Override method to get the pace for running activity
    public override double GetPace()
    {
        return _minutes / _distance;
    }

    // Override method to get the summary information for running activity
    public override string GetSummary()
    {
        string distanceUnit = "miles"; // You can change this to "kilometers" if needed
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{base.GetSummary()} Running - Distance {_distance:F1} {distanceUnit}, Speed {speed:F1} mph, Pace: {pace:F1} min per {distanceUnit}";
    }
}
