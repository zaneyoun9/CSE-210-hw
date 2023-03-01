using System;

public class Activity
{
   protected int _duration = 0;
   protected string _startPrompt = " ";

   protected string _activity = " ";

   public void Timer()
   {

   }
   public void Spinner()
   {
    Console.Write($"/");
    Thread.Sleep(500);
    Console.Write($"\b-");
    Thread.Sleep(500);
    Console.Write($"\b\\");
    Thread.Sleep(500);
    Console.Write($"\b|");
    Thread.Sleep(500);
    Console.Write($"\b/");
    Console.Write($"\b");

   }
   public void DisplayStart(string _activity, string _activityDescription)
   {
    Console.WriteLine($"Welcome to the {_activity} Activity.");
    Console.WriteLine();
    Console.WriteLine(_activityDescription);
    Console.WriteLine();
    _duration = PromptDuration();
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("Get Ready...");
    Spinner();
    Console.WriteLine();
    Console.WriteLine();
    

   }
   public int PromptDuration()
   {
    Console.WriteLine("How long, in seconds, would you like your session? ");
    string _durationString = Console.ReadLine();
    int _duration = int.Parse(_durationString);
    return _duration;
   }
   public void DisplayEnd(int _duration, string _activity)
   {
    Console.WriteLine("Well Done!!");
    Spinner();
    Console.WriteLine($"You have completed another {_duration} seconds of the {_activity} Activity.");
    Thread.Sleep(1000);
   }
}
