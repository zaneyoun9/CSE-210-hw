public class Lecture : Event
{
    string _speaker = "";
    int _capacity = 0;
    string _capacityStr = "";
    
    
    public void CreateLecture()
    {
        _eventType = "Lecture";
        CreateEvent();
        Console.WriteLine("Who is the speaker?");
        _speaker = Console.ReadLine();
        Console.WriteLine("How many people can attend?");
        _capacityStr = Console.ReadLine();
        _capacity = int.Parse(_capacityStr);
    }
    public void DisplayLecture()
    {
        Console.Write($"{_eventType}, ");
        DisplayStandard();
        Console.WriteLine($", {_speaker}, {_capacity}");
    }

    public override void DisplayFull()
    {
        base.DisplayFull();
        Console.WriteLine($", {_eventType}, {_speaker}, {_capacity}");
    }
    public override void DisplayShortDesc()
    {
        Console.Write($"{_eventType}, ");
        base.DisplayShortDesc();
    }
}