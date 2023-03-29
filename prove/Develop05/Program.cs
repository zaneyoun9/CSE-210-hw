using System;

class Program
{
    static void Main(string[] args)
    {
        int _userChoice = 0;
        string _userChoiceStr = "";
        int _goalChoice = 0;
        string _goalChoiceStr = "";

        while(_userChoice != 6)
        {
        Console.WriteLine("Menu options");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        _userChoiceStr = Console.ReadLine();
        _userChoice = int.Parse(_userChoiceStr);
        if(_userChoice == 1)
        {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        _goalChoiceStr = Console.ReadLine();
        _goalChoice = int.Parse(_goalChoiceStr);

        }
        }
        
    }
}