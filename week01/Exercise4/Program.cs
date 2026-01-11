using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int numbers;

        List<int> numbersList = new List<int>();

        while (true)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            numbers = int.Parse(userInput);

            if (numbers == 0)
                break;

            numbersList.Add(numbers);
        }

        Console.WriteLine();
        int sum = numbersList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbersList.Average();
        Console.WriteLine($"The average is: {average}");

        int largest = numbersList.Max();
        Console.WriteLine($"The largest number is: {largest}");

        int smallestPositive = numbersList
            .Where(n => n > 0)
            .DefaultIfEmpty()
            .Min();

        if (smallestPositive == 0)
        {
            Console.WriteLine("No postive numbers found.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        List<int> sortedNumbers = numbersList.OrderBy(n => n).ToList();

        Console.WriteLine($"The sorted list is: \n");
        foreach (int n in sortedNumbers)
        {
            Console.WriteLine(n);
        }
    }
}