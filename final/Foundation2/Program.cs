using System;

class Program
{
    static void Main(string[] args)
    {
        string _userInputStr = "";
        int  _userInput = 0;
        List<Order> _orderList = new List<Order>();
        while(_userInput != 3)
        {
        Console.WriteLine($"1: Create Order   2: Display   3: Quit ");
        _userInputStr = Console.ReadLine();
        _userInput = int.Parse(_userInputStr);
        if (_userInput == 1)
        {
            Order or = new Order();
            or.CreateOrder();
            _orderList.Add(or);

        }
        else if (_userInput == 2)
        {
            foreach (Order or in _orderList)
            {
                or.DisplayShippingLabel();
                Console.WriteLine();
                or.DisplayPackingLabel();
                Console.WriteLine();
                or.ComputeOrderTotal();
                Console.WriteLine();
            }
        }
        
        
    }
}}