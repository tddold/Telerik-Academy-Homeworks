/*
Problem 1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.
*/

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Please enter a number: ");

        string input = Console.ReadLine();
        int number;

        bool parseSuccess = Int32.TryParse(input, out number);
        string result;

        if (number % 2 == 0)
        {
            result = "even";
        }
        else
        {
            result = "odd";
        }

        Console.WriteLine(parseSuccess ? "Your number is {0}" : "Invalid number!", result);
    }
}

