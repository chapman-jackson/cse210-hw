public class Running : Activity
{
    private double _distance;
    public Running(string date, double minutes, double distance) : base (date, minutes)
    {
        _date = date;
        _minutes = minutes;
        _distance = distance;
    }

    public override string getActivitySummaryString()
    {
        return $"{_date} Running ({_minutes}) - Distance {getDistance()} Miles, Speed: {getSpeed()} mph, Pace: {getPace()} min per mile";
    }

    public override double getDistance()
    {
        return _distance;
    }

    public override double getPace()
    {
        double pace = _minutes / _distance;

        return pace;
    }

    public override double getSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }
}