using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign = "";

        // Determines letter grades
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determines signs (+ or - grades)
        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Special cases
        if (letter == "A" && sign == "+")
        {
            sign = "";  // There is no A+
        }

        if (letter == "F")
        {
            sign = "";  // There is no F+ or F-
        }


        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You got a passing grade");
        }
        else
        {
            Console.WriteLine("Try again");
        }
    }
}