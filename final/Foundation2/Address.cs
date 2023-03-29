public class Address
{
    string _streetAddress = "";
    string _city = "";
    string _state = "";
    string _country = "";
    public bool _isUSA = false;

    public void CreateAddress()
    {
        Console.WriteLine("What is your street address?");
        _streetAddress = Console.ReadLine();
        Console.WriteLine("Which city do you live in?");
        _city = Console.ReadLine();
        Console.WriteLine("What state or province(if applicable)?");
        _state = Console.ReadLine();
        Console.WriteLine("What country do you live in?");
        _country = Console.ReadLine();
    }

    public bool CheckUS()
    {
        if (_country.ToLower() == "us" || _country.ToLower() == "america" || _country.ToLower() == "usa" || _country.ToLower() == "united states")
        {
            _isUSA = true;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}, {_city}, {_state} {_country}");
    }
}