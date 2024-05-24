public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {
        _goalType = goalType;
        _shortName = name;
        _description = description;
        _points = points;

    }

    public SimpleGoal(string goalType, string name, string description, int points, bool isComplete) : base(goalType, name, description, points)
    {
        _goalType = goalType;
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        
        if (IsComplete())
        {
            Console.WriteLine("You already completed this goal!");
            return 0;
        }

        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string simpleRepresentation = $"{_goalType}---{_shortName}---{_description}---{_points}---{_isComplete}";
       return simpleRepresentation;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
}