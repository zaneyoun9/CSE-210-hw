using System;

public class Listing : Activity
{

    public void Display(){
    _startPrompt = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    _activity = "Listing";
    DisplayStart(_activity, _startPrompt);
    DisplayEnd(_duration, _activity);

    }
}