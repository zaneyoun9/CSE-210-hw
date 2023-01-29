using System;
using static Job;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job lameo = new Job();
        Job cool = new Job();
        string s = "programming is fun";
        lameo.Main(s);
        Console.WriteLine(lameo.h);
        lameo.h = "here was hunter";
        Console.WriteLine(lameo.getZ());
        string bruh = Console.ReadLine();
        lameo.setZ(bruh);
        Console.WriteLine(lameo.getZ());


    }
}