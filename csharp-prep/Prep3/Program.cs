using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = 0;
        Console.WriteLine(number);
        while (guess != number)
        {
            Console.Write("What is the magic number? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            if (guess > number)
            {
                Console.WriteLine("Your guess was too high.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Your guess was too low.");
            }
            else
            {
                Console.WriteLine("You guessed the number!");
            }
        }
    }
}