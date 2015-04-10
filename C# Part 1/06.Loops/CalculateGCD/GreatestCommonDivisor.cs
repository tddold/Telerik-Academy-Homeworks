/*
Problem 17.* Calculate GCD

Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).
*/

using System;

class GreatestCommonDivisor
{
    static void Main()
    {

        Console.Write("Please enter your first integer number: ");
        int firstNumber = Int32.Parse(Console.ReadLine());

        Console.Write("Please enter your second integer number: ");
        int secondNumber = Int32.Parse(Console.ReadLine());
        int first = Math.Abs(firstNumber);
        int second = Math.Abs(secondNumber);

        while (first != 0 && second != 0)
        {
            if (first > second)
            {
                first %= second;
            }
            else
            {
                second %= first;
            }
        }

        if (first == 0)
        {
            Console.WriteLine("The greatest common divisor (GCD) of {0} and {1} is {2}", firstNumber, secondNumber, second);
        }
        else
        {
            Console.WriteLine("The greatest common divisor (GCD) of {0} and {1} is {2}", firstNumber, secondNumber, first);
        }
    }
}

