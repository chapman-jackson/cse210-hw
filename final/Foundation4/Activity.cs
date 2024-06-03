public abstract class Activity 
{
    protected string _date;
    protected double _minutes;

    public Activity( string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual string getActivitySummaryString()
    {
        return"";
    }

    public virtual double getDistance()
    {
        return 0;
    }

    public virtual double getSpeed()
    {
        return 0;
    }

    public virtual double getPace()
    {
        return 0;
    }

    
}