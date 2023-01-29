using System;

public class Job
{
    public string h = "Hunter rules";
    private string z = "zane was here";
    public void Main(string args)
    {
        Console.WriteLine(args);

    }
    public string getZ()
    {
        return z;
    }
    public void setZ(string s)
    {
        z = s;
    }
}