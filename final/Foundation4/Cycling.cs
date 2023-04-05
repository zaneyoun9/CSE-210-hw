public class Cycling : Activity
{
    string _speedStr = "";

    public override void CreateActivity()
    {
        _activityType = "Cycling";
        base.CreateActivity();
        Console.WriteLine("How fast were you going in KMpH?");
        _speedStr = Console.ReadLine();
        _speed = double.Parse(_speedStr);
    }

    public override double CalculatePace()
    {
        _pace = 60 / _speed;
        return _pace;
        return base.CalculatePace();
    }

    public override double CalculateSpeed()
    {
        return _speed;
        return base.CalculateSpeed();
    }
    public override double CalculateDistance()
    {
        _distance = (_speed / 60) * _duration;
        return _distance;
        return base.CalculateDistance();
    }
}