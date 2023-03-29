public class Order
{
    double _orderTotal = 0;
    List<Product> _productList = new List<Product>();
    Customer cust = new Customer();
    Address addr = new Address();
    string _checkUsChoice = "";
    string _choice = "y";
    public void ComputeOrderTotal()
    {
        foreach (Product p in _productList)
        {
           _orderTotal += p.CalculateItemSum();
        }
        if (!addr.CheckUS())
        {
            _orderTotal += 35;
        }
        Console.WriteLine(_orderTotal);
    }
    public void DisplayShippingLabel()
    {
        foreach (Product p in _productList)
        {
            p.DisplayLabel();
        }
    }

    public void DisplayPackingLabel()
    {

        cust.DisplayLabel();
        addr.DisplayAddress();
    }
    public void CreateOrder()
    {
        cust.CreateCustomer();
        addr.CreateAddress();
        Console.WriteLine("Would you like to see if you qualify for free shipping in the US? (y/n)");
        _checkUsChoice = Console.ReadLine();
        if (_checkUsChoice == "y")
        {
        addr.CheckUS();
        if (addr._isUSA)
        {
            Console.WriteLine("You are in the US.");
            
        }
        else
        {
            Console.WriteLine("You are not in the US.");
        }
        }
        while (_choice == "y")
        {
            Product p = new Product();
            p.CreateProduct();
            _productList.Add(p);
            Console.WriteLine("Would you like to add another item (y/n)?");
            _choice = Console.ReadLine();
        }
    

    }
}