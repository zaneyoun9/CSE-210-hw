using System;

class Program
{
    static void Main(string[] args)
    {
        string _userInput1Str = "";
        int _userInput1 = 0;
        string _userInput2Str = "";
        int _userInput2 = 0;
        List<Activity> _activityList = new List<Activity>();
        while (_userInput1 != 3)
        {
            Console.WriteLine("1 Create New Activity  2 Get Activity Summaries  3 quit");
            _userInput1Str = Console.ReadLine();
            _userInput1 = int.Parse(_userInput1Str);
            
            if (_userInput1 == 1)
            {
                Console.WriteLine("What type of event would you like to create?");
                Console.WriteLine("1 Running  2 Cycling  3 Swimming");
                _userInput2Str = Console.ReadLine();
                _userInput2 = int.Parse(_userInput2Str);
                if (_userInput2 == 1)
                {
                    Running r = new Running();
                    r.CreateActivity();
                    _activityList.Add(r);
                }
                else if (_userInput2 == 2)
                {
                    Cycling c = new Cycling();
                    c.CreateActivity();
                    _activityList.Add(c);
                }
                else 
                {

                    Swimming s = new Swimming();
                    s.CreateActivity();
                    _activityList.Add(s);
                }
            }
            else if (_userInput1 == 2)
            {

                foreach (Activity act in _activityList)
                {
                    act.GetSummary();
                }
            }
            else 
            {
                Console.WriteLine("Quitting...");
            }
        }
    }
}