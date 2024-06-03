public class Biking : Activity
{
    private double _speed;
    private double _distance;
    public Biking(string date, double minutes, double speed, double distance) : base(date, minutes)
    {
        _date = date;
        _minutes = minutes;
        _speed = speed;
        _distance = distance;
    }

    public override string getActivitySummaryString()
    {
         return $"{_date} Biking ({_minutes}) - Distance {getDistance()} Miles, Speed: {getSpeed()} mph, Pace: {getPace()} min per mile";
    }

    public override double getDistance()
    {
        return _distance;
    }

    public override double getPace()
    {
        double pace = 60 / getSpeed();
        return pace;
    }

    public override double getSpeed()
    {
        return _speed;
    }
}