using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int sqNum = SquareNumber(userNum);

        DisplayResult(userName, sqNum);
        static void DisplayMessage()
        {
        Console.WriteLine("Welcome to the program");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numStr = Console.ReadLine();
            int userNum = int.Parse(numStr);
            return userNum;
        }
        static int SquareNumber(int userNum)
        {
            int sqNum = (userNum * userNum);
            return sqNum;
        }
        static void DisplayResult(string userName, int sqNum)
        {
            Console.WriteLine($"{userName}, the square of your number is {sqNum}");
        }
    }
}