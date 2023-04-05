using System;

class Program
{
    static void Main(string[] args)
    {
        string _userInput1Str = "";
        int _userInput1 = 0;
        string _userInput2Str = "";
        int _userInput2 = 0;
        int _listCount = -1;
        List<Event> _eventList = new List<Event>();
        while (_userInput1 != 3)
        {
            Console.WriteLine("1 Create New Event  2 Display Events  3 quit");
            _userInput1Str = Console.ReadLine();
            _userInput1 = int.Parse(_userInput1Str);
            
            if (_userInput1 == 1)
            {
                Console.WriteLine("What type of event would you like to create?");
                Console.WriteLine("1 Lecture  2 Reception  3 Outdoor");
                _userInput2Str = Console.ReadLine();
                _userInput2 = int.Parse(_userInput2Str);
                if (_userInput2 == 1)
                {
                    Lecture l = new Lecture();
                    l.CreateLecture();
                    _eventList.Add(l);
                }
                else if (_userInput2 == 2)
                {
                    Reception r = new Reception();
                    r.CreateRecpetion();
                    _eventList.Add(r);
                }
                else 
                {

                    Outdoor o = new Outdoor();
                    o.CreateOutdoor();
                    _eventList.Add(o);
                }
            }
            else if (_userInput1 == 2)
            {

                foreach (Event eve in _eventList)
                {
                    eve.DisplayStandard();
                    Console.WriteLine();
                    eve.DisplayFull();
                    Console.WriteLine();
                    eve.DisplayShortDesc();
                    Console.WriteLine();
                }
            }
            else 
            {
                Console.WriteLine("Quitting...");
            }
        }
    }
}