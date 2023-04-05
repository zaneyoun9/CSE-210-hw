public class Activity
{
    protected double _distance = 0;
    protected double _speed = 0;
    protected double _pace = 0;
    string _date = "";
    protected int _duration = 0;
    string _durationStr = "";
    protected string _activityType = "";

    public void GetSummary()
    {
        Console.WriteLine($"{_date} ({_activityType}): Distance {CalculateDistance} km, Speed {CalculateSpeed} kph, Pace {CalculatePace} min per km");

    }
    public virtual void CreateActivity()
    {
        Console.WriteLine("What is the date the activity took place?");
        _date = Console.ReadLine();
        Console.WriteLine("How long did the activity last in minutes?");
        _durationStr = Console.ReadLine();
        _duration = int.Parse(_durationStr);
    }

    public virtual double CalculatePace()
    {
        return _pace;
    }
    public virtual double CalculateSpeed()
    {
        return _speed;
    }

    public virtual double CalculateDistance()
    {
        return _distance;
    }

}