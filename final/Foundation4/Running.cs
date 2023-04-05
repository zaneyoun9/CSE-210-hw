public class Running : Activity
{
    string _distanceStr = "";

    public override void CreateActivity()
    {
        _activityType = "Running";
        base.CreateActivity();
        Console.WriteLine("How far did you go in KM?");
        _distanceStr = Console.ReadLine();
        _distance = double.Parse(_distanceStr);
    }
    public override double CalculatePace()
    {
        _pace = _duration / _distance;
        return _pace;
        return base.CalculatePace();
    }
    public override double CalculateSpeed()
    {
        _speed = (_distance / _duration) * 60;
        return _speed;
        return base.CalculateSpeed();
    }
    public override double CalculateDistance()
    {
        return _distance;
        return base.CalculateDistance();
    }
}