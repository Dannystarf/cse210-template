using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        while (true)
        {
            Console.Write("Enter your grade percentage(0-100): ");
            string gradePercentage = Console.ReadLine();
            grade = int.Parse(gradePercentage);

            if (grade >= 0 && grade <= 100)
                break;

            Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
            Console.WriteLine();
        }

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int remainder = grade % 10;

        if (remainder >= 7)
        {
            sign = "+";

        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (grade == 100)
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Grade: {letter}{sign}");


        if (grade >= 70)
        {
            Console.WriteLine("Congratualtions! You pass the class.");
        }
        else
        {
            Console.WriteLine("Failed!, but you can do better next time.");
        }
    }
}