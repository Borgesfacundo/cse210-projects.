class SimpleGoal : CompletableGoal
{
    public override int RecordEvent()
    {
        isCompleted = true;
        return _points;
    }
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public SimpleGoal(string savedString) : base(savedString)
    {
        string[] parts = savedString.Split(",");
        string typeOfGoal = parts[0];
        SetName(parts[1]);
        _description = parts[2];
        _points = int.Parse(parts[3]);
        if (parts[4] == "true")
        {
            isCompleted = true;
        }
        else 
        {
            isCompleted = false;
        }
    }

}