using System;

public class Program
{
    static void Main(string[] args)
    {
        string reference = "Proverbs 3:5-6";
        List<string> verses = new List<string>
            { 
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
                 "In all thy ways acknowledge him, and he shall direct thy paths."

            };
        string userInputContinue = " ";
        bool continueStatus = true;
        Scripture scrip = new Scripture(verses);

        while (continueStatus == true) 
        {
            Console.Write($"{reference}: ");
            scrip.Display();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInputContinue = Console.ReadLine();
            scrip.HideWords(3);
            scrip.IsAllHidden();
            if (userInputContinue == "quit")
            {
                continueStatus = false;
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
