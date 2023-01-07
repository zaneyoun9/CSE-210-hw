using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your score? ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);
        string grade = " ";

        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (score >= 70)
        {
            Console.WriteLine($"Congratulations you passed the class and your grade was a(n) {grade}.");
        }
        else
        {
            Console.WriteLine($"Unfortunately your grade was a(n) {grade}. You did not pass the class, Good luck on your next attempt.");
        }
    }
}