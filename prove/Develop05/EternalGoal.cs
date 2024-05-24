public class EternalGoal : Goal
{
    public EternalGoal(string goalType, string name, string description, int points) : base( goalType, name, description, points)
    {
        _goalType = goalType;
        _shortName = name;
        _description = description;
        _points = points;
    }


     public override string GetStringRepresentation()
    {
        return $"{_goalType}---{_shortName}---{_description}---{_points}";
  
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
}