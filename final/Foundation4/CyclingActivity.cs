public class CyclingActivity : Activity
{
    private double _speed;

    // Constructor to initialize cycling activity with speed
    public CyclingActivity(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // Override method to get the speed for cycling activity
    public override double GetSpeed()
    {
        return _speed;
    }

    // Override method to get the pace for cycling activity
    public override double GetPace()
    {
        return 60 / _speed;
    }

    // Override method to get the summary information for cycling activity
    public override string GetSummary()
    {
        string distanceUnit = "kilometers"; // You can change this to "miles" if needed
        double distance = GetDistance();
        double pace = GetPace();

        return $"{base.GetSummary()} Cycling - Speed {_speed:F1} kph, Pace: {pace:F1} min per {distanceUnit}";
    }
}
