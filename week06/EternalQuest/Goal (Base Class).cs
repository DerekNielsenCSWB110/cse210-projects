public abstract class Goal
{
    // Member Variables
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    // Methods
    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public abstract int RecordEvent();  
    // Returns points earned

    public virtual string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }

    public abstract string GetStringRepresentation();
}
