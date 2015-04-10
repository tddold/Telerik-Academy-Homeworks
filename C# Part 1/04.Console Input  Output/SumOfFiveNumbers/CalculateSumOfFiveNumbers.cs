/*
Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
*/

using System;
using System.Globalization;
using System.Threading;

class CalculateSumOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please enter five numbers separated by a space: ");
        string numbers = Console.ReadLine();
        string[] numberArray = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        double sum = 0;

        for (int index = 0; index < numberArray.Length; index++)
        {
            sum += Double.Parse(numberArray[index]);
        }
        Console.WriteLine("The sum of your five numbers is: {0}", sum);
    }
}