using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        string _choiceStr= "";
        int _choice = 0;
        while (_choice != 3)
        {
            
            Console.WriteLine($"1 create video  2 display  3 quit");
            _choiceStr = Console.ReadLine();
            _choice = int.Parse(_choiceStr);
            if (_choice == 1)
            {
                Video vid = new Video();
                vid.CreateVideo();
                _videos.Add(vid);
                
            }
            else if (_choice == 2)
            {
                foreach (Video v in _videos)
                    {
                        v.Display();
                    }
            }
        }
    }
}