public class Event
{
    protected string _eventType = "";
    string _title = "";
    string _description = "";
    string _date = "";
    string _time = "";
    string _address = "";

    public void CreateEvent()
    {
        Console.WriteLine("What is the title of the event?");
        _title = Console.ReadLine();
        Console.WriteLine("What is a description of the event?");
        _description = Console.ReadLine();
        Console.WriteLine("What date is the event?");
        _date = Console.ReadLine();
        Console.WriteLine("What time is the event?");
        _time = Console.ReadLine();
        Console.WriteLine("Where is the event taking place?");
        _address = Console.ReadLine();
    }
    public void DisplayStandard()
    {
        Console.Write($"{_title}, {_description}, {_date}, {_time}, {_address}");
    }
    public virtual void DisplayFull()
    {
        DisplayStandard();
    }
    public virtual void DisplayShortDesc()
    {
        Console.WriteLine($"{_title}, {_date}");
    }
}