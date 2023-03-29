public class Goals
{
    bool _completed = false;
    int _points = 0;
    string _pointsStr = "";
    string _goalName = "";
    string _goalDesc = "";
    string _completedStatus = "";
    

    public void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDesc = Console.ReadLine();
        Console.Write("How many points are associated with this goal? ");
        _pointsStr = Console.ReadLine();
        _points = int.Parse(_pointsStr);
    }
    public string CheckDisplay()
    {
        if (_completed == true)
        {
            _completedStatus = "{x}";
            return _completedStatus;
        }
        else
        {
            _completedStatus = "{ }";
            return _completedStatus;
        }
    }
    public void DisplayGoal()
    {
        Console.WriteLine($"{CheckDisplay} {_goalName} ({_goalDesc})");
    }
}