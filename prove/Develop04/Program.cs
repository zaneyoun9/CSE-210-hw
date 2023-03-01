using System;

class Program
{
    static void Main(string[] args)
    {
        Activity act = new Activity();
        Breathing breathe = new Breathing();
        Reflection reflect = new Reflection();
        Listing listing = new Listing();
        int _choice = 0;
        
        do{
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activity");
        Console.WriteLine(" 4. Quit");
        Console.Write("Select a choice from the menu: ");
        string _choiceString = Console.ReadLine();
        _choice = int.Parse(_choiceString);
        if(_choice == 1){
            breathe.CountdownDisplay();
        }
        else if(_choice == 2){
            reflect.Display();
        }
        else if(_choice == 3){
            listing.Display();
        }
        }
        while (_choice != 4);
    }
}