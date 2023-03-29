public class Customer
{
    string _custName = "";


    public void CreateCustomer()
    {
        Console.WriteLine("what is your name?");
        _custName = Console.ReadLine();


    }
    public void DisplayLabel()
        {
            Console.WriteLine($"{_custName},");

        }
}