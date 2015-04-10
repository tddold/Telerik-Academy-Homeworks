/*
Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.
*/

using System;
using System.Globalization;
using System.Threading;

class SortThreeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Enter your first number: ");
        double firstNumber = Double.Parse(Console.ReadLine());

        Console.Write("Enter your second number: ");
        double secondNumber = Double.Parse(Console.ReadLine());

        Console.Write("Enter your third number: ");
        double thirdNumber = Double.Parse(Console.ReadLine());

        if (firstNumber <= secondNumber && firstNumber <= thirdNumber && secondNumber <= thirdNumber)
        {
            Console.WriteLine("Your numbers sorted in descending order: {0} {1} {2}", thirdNumber, secondNumber, firstNumber);
        }
        else if (firstNumber <= secondNumber && firstNumber <= thirdNumber && secondNumber >= thirdNumber)
        {
            Console.WriteLine("Your numbers sorted in descending order: {0} {1} {2}", secondNumber, thirdNumber, firstNumber);
        }
        else if (firstNumber >= secondNumber && firstNumber <= thirdNumber && secondNumber <= thirdNumber)
        {
            Console.WriteLine("Your numbers sorted in descending order: {0} {1} {2}", thirdNumber, firstNumber, secondNumber);
        }
        else if (firstNumber <= secondNumber && firstNumber >= thirdNumber && secondNumber >= thirdNumber)
        {
            Console.WriteLine("Your numbers sorted in descending order: {0} {1} {2}", secondNumber, firstNumber, thirdNumber);
        }
        else if (firstNumber >= secondNumber && firstNumber >= thirdNumber && secondNumber <= thirdNumber)
        {
            Console.WriteLine("Your numbers sorted in descending order: {0} {1} {2}", firstNumber, thirdNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("Your numbers sorted in descending order: {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
        }
    }
}

