using System;

public class Breathing : Activity
{
    public void CountdownDisplay()
    {
    Console.Clear();
     _startPrompt = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
     _activity = "Breathing";
     DisplayStart(_activity, _startPrompt);
     for (int i = 0; i < (_duration/6); i++){
    
     Console.Write("Breathe in... ");
     Thread.Sleep(1000);
     Console.Write($"\b1");
     Thread.Sleep(1000);
     Console.Write($"\b2");
     Thread.Sleep(1000);
     Console.Write($"\b3");
     Console.WriteLine($"\b");

     Console.Write("Now breathe out... ");
     Thread.Sleep(1000);
     Console.Write($"\b1");
     Thread.Sleep(1000);
     Console.Write($"\b2");
     Thread.Sleep(1000);
     Console.Write($"\b3");
     Console.WriteLine($"\b");
     }
     DisplayEnd(_duration, _activity);
    }
}
