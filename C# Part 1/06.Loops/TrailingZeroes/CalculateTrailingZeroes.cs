/*
Problem 18.* Trailing Zeroes in N!

Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
*/

using System;
using System.Numerics;

class CalculateTrailingZeroes
{
    static void Main()
    {
        Console.Write("Please enter a positive integer: ");
        int number = Int32.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        int counter = 0;
        BigInteger calculateNewNumber;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        while (true)
        {
            calculateNewNumber = factorial % 10;

            factorial = factorial / 10;

            if (calculateNewNumber == 0)
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Trailing Zeroes = {0}", counter);

    }
}

