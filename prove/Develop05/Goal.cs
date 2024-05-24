public abstract class Goal
{
    protected string _goalType;
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string goalType,string name,string description,int points)
    {
        _goalType = goalType;
        
        _shortName = name;

        _description = description;

        _points = points;
    }

    public abstract int RecordEvent();
    

    public abstract bool IsComplete();
   

    public abstract string GetDetailsString();
    
   
    public abstract string GetStringRepresentation();
    
    public string GetGoalType()
    {
        return _goalType;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }
}