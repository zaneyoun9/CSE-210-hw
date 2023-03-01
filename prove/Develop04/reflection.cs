using System;

public class Reflection : Activity
{
    private int _randomIndex = -1;

    private List<string> _promptList = new List<string>();
    
    private void GenerateRandomIndex()
    {
        Random _randomGenerator = new Random();
        _randomIndex = _randomGenerator.Next(0, _promptList.Count);
    }

    
    public void Display()
    {
    
    _activity = "Reflection";
    _startPrompt = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    DisplayStart(_activity, _startPrompt);
    GenerateRandomIndex();
    DisplayEnd(_duration, _activity);



    }
}