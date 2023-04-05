public class Outdoor : Event
{
    string _weather = "";

    public void CreateOutdoor()
    {
        _eventType = "Outdoor";
        CreateEvent();
        Console.WriteLine("What is the weather like for the event?");
        _weather = Console.ReadLine();
    }
    public void DisplayOutdoor()
    {
        Console.Write($"{_eventType}, ");
        DisplayStandard();
        Console.WriteLine($", {_weather}");
    }
    public override void DisplayFull()
    {
        base.DisplayFull();
        Console.Write($", {_eventType}, {_weather}");
    }
    public override void DisplayShortDesc()
    {
        Console.Write($"{_eventType}, ");
        base.DisplayShortDesc();
    }
}