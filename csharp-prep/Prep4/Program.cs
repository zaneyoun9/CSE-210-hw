using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numberList;
        numberList = new List<int>();
        int newNum = 1;
        string newString = " ";
        float sum = 0;
        float average = 0;

        while (newNum != 0)
        {
            Console.Write("What number would you like to add? ");
            newString = Console.ReadLine();
            newNum = int.Parse(newString);
            sum += newNum;
            if (newNum != 0)
            {
                numberList.Add(newNum);
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        average = (sum / numberList.Count);
        Console.WriteLine($"The average is: {average}");

        int max = numberList.Max();
        Console.WriteLine($"The Largest number is: {max}");

    }   
}