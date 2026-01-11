using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            int guess;

            int guessCount = +1;

            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 100);

            Console.WriteLine("A random number have been generated between 1-100, can you try guessing it?");

            while (true)
            {
                Console.Write("What is your guess? ");
                string guessNumber = Console.ReadLine();
                guess = int.Parse(guessNumber);

                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                if (guess == magic)
                {
                    break;
                }

                guessCount++;
            }

            Console.WriteLine();
            Console.WriteLine($"You made a total of {guessCount} guess(es)");

            Console.WriteLine();
            Console.Write("Do you want to play again (y/n)? ");
            response = Console.ReadLine();
            Console.WriteLine();
        } while (response == "y");
    }
}