public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string goalType, string name, string description, int points, int bonus, int target): base(goalType, name, description, points)
    {
        _goalType = goalType;
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string goalType, string name, string description, int points, int bonus, int target, int amountCompleted): base(goalType,name, description, points)
    {
        _goalType = goalType;
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {

        _amountCompleted = _amountCompleted + 1;

        if( IsComplete())
        {
            return _bonus + _points;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {

        return $"{_goalType}---{_shortName}---{_description}---{_points}---{_bonus}---{_target}---{_amountCompleted}";
    }
}