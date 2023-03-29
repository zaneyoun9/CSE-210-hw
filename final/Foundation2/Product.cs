public class Product
{
    string _prodName = "";
    string _prodId = "";
    string _priceStr = "";
    double _price = 0;
    string _quantityStr = "";
    int _quantity = 0;
    double _itemTotal = 0;
    
    public void CreateProduct()
    {
        Console.WriteLine("what is the name of the product");
        _prodName = Console.ReadLine();
        Console.WriteLine("What is the product Id");
        _prodId = Console.ReadLine();
        Console.WriteLine("What is the price of the item?");
        _priceStr = Console.ReadLine();
        _price = double.Parse(_priceStr);
        Console.WriteLine("How much would you like to purchase");
        _quantityStr = Console.ReadLine();
        _quantity = int.Parse(_quantityStr);
        CalculateItemSum();        
    }

    public double CalculateItemSum()
    {
       _itemTotal = _price * _quantity;
       return _itemTotal;
    }
    public void DisplayLabel()
    {
        Console.WriteLine($"{_prodName}, {_prodId}");
    }
}