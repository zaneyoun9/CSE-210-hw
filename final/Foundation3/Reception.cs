public class Reception : Event
{
    string _email = "";

    public void CreateRecpetion()
    {
        _eventType = "Reception";
        CreateEvent();
        Console.WriteLine("What is the email for RSVP?");
        _email = Console.ReadLine();
    }

    public void DisplayReception()
    {
        Console.Write($"{_eventType}, ");
        DisplayStandard();
        Console.WriteLine($", {_email}");
    }
    public override void DisplayFull()
    {
        base.DisplayFull();
        Console.WriteLine($", {_eventType}, {_email}");
    }
    public override void DisplayShortDesc()
    {
        Console.Write($"{_eventType}, ");
        base.DisplayShortDesc();
    }
}