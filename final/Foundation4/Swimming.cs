using System.Reflection.Metadata.Ecma335;

public class Swimming : Activity
{
   private int _laps;
    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override string getActivitySummaryString()
    {
        return $"{_date} Swimming ({_minutes}) - Distance {getDistance():F2} Miles, Speed: {getSpeed():F2} mph, Pace: {getPace():F2} min per mile";
    }

    public override double getDistance()
    {
        double distanceKilometers = (_laps * 50) / 1000.0; 
        double distanceMiles = distanceKilometers * 0.62;
        return distanceMiles;
    }

      public override double getPace()
    {
        double pace = _minutes / getDistance();

        return pace;
    }

    public override double getSpeed()
    {
        double pace = getPace();
        double speed = 60 / pace;
        return speed;
    }
}