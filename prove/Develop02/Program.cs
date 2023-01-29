using System;

public class Entry
{
    public string date;
    public string dailyPrompt;
    public string entryText;
    public int GenerateRandomIndex(int size)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, size - 1);
        return number;
    }
    public string GetPrompt(List<string> _promptList)
    {
        return _promptList[GenerateRandomIndex(_promptList.Count)];
    }
    public void CreateEntry(List<string> _promptList)
    {
        dailyPrompt = GetPrompt(_promptList);
        Console.WriteLine(dailyPrompt);
        entryText = Console.ReadLine();
    }
}

public class Journal
    {
        string _file = " ";
        public List<string> _promptList = new List<string>();
        public List<Entry> _entriesList = new List<Entry>();
        public Journal()
        {
            List<string> _entries;
            _entries = new List<string>();
            // List<string> _promptList;
            //_promptList = new List<string>();
            _promptList.Add("Who was the most interesting person I interacted with today?");
            _promptList.Add("What was the best part of my day?");
            _promptList.Add("How did I see the hand of the Lord in my life today?");
            _promptList.Add("What was the strongest emotion I felt today?");
            _promptList.Add("If I had one thing I could do over today, what would it be?");
            _promptList.Add("What is one way that I improved today?");
            _promptList.Add("What was the best thing I decided to spend my time on today?");
        }
        public void Save()
        {
            Console.WriteLine("What would you like the file to be named? ");
            _file = Console.ReadLine();

        }
        public void Load()
        {
            Console.WriteLine("What file would you like to open? ");
            _file = Console.ReadLine();

        }
    }

public class Menu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        }
        public int GetInput()
        {
            Console.Write("What would you like to do? ");
            string _menuInputStr = Console.ReadLine();
            int _menuInput = int.Parse(_menuInputStr);
            return _menuInput;
        }
    }

class Program
{
    static void Main(string[] args)
    {
        Entry en = new Entry();
        Menu menu = new Menu();
        menu.Display();
        Journal j = new Journal();
        bool cont = true;
        while (cont)
        {
            menu.Display();
            switch (menu.GetInput())
                {
                case 1:
                    Entry e = new Entry();
                    e.CreateEntry(j._promptList);
                    j._entriesList.Add(e);
                    break;
                case 2:
                for (int i = 0; i < j._entriesList.Count; i++)
                {
                    Console.WriteLine(j._entriesList[i].dailyPrompt);
                    Console.WriteLine(j._entriesList[i].entryText);
                }
                    break;
                case 3:
                    j.Load();
                    break;
                case 4:
                    j.Save();
                    break;
                case 5:
                    cont = false;
                    break;
                default:
                    Console.WriteLine("only input values on the menu");
                    break;
            }
        }
        // Console.WriteLine("Hello Develop02 World!");
        //TYPE variable_name = new TYPE();
        
    //     int num = 42;
    //     j.journal_test(num);
    // }
}
}