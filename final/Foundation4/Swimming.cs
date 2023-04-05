public class Swimming : Activity
{
    int _laps = 0;
    string _lapsStr = "";

    public override void CreateActivity()
    {
        _activityType = "swimming";
        base.CreateActivity();
        Console.WriteLine("How many laps did you swim?");
        _lapsStr = Console.ReadLine();
        _laps = int.Parse(_lapsStr);
    }
    public override double CalculateDistance()
    {
        _distance = _laps * 50 / 1000;
        return _distance;
        return base.CalculateDistance();
    }

    public override double CalculatePace()
    {
        _pace = _duration / _distance;
        return _pace;
        return base.CalculatePace();
    }
    public override double CalculateSpeed()
    {
        _speed = 60 / _pace;
        return base.CalculateSpeed();
    }
}