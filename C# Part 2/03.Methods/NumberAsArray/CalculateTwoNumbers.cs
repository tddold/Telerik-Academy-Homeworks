/*
Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
*/

using System;


class CalculateTwoNumbers
{
    static string AddingTwoNumber(string firstNumber, string secondNumber)
    {
        string sum = string.Empty;

        int difference = Math.Max(firstNumber.Length, secondNumber.Length) - Math.Min(firstNumber.Length, secondNumber.Length);

        if (firstNumber.Length > secondNumber.Length)
        {
            secondNumber = new string('0', difference) + secondNumber;
        }
        else if (firstNumber.Length < secondNumber.Length)
        {
            firstNumber = new string('0', difference) + firstNumber;
        }

        int currentSum = 0;
        int remainderPlus = 0;

        for (int i = 0; i < firstNumber.Length; i++)
        {
            currentSum = (firstNumber[firstNumber.Length - 1 - i] - '0') + (secondNumber[secondNumber.Length - 1 - i] - '0') + remainderPlus;

            remainderPlus = currentSum / 10;

            if (currentSum % 10 == 0)
            {
                sum = 0 + sum;
            }
            else if (currentSum % 10 != 0)
            {
                sum = (currentSum % 10) + sum;
            }

            if (i == firstNumber.Length - 1 && remainderPlus != 0)
            {
                sum = remainderPlus + sum;
            }
        }
        return sum;
    }
    static void Main()
    {
        Console.Write("Please enter your first number: ");
        string firstNumber = Console.ReadLine();

        Console.Write("Please enter your second number: ");
        string secondNumber = Console.ReadLine();

        string sum = AddingTwoNumber(firstNumber, secondNumber);

        Console.WriteLine("The sum of your two number is: {0}", sum);

    }
}

