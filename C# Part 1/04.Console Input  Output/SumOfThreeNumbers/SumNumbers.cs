/*
Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
*/

using System;
using System.Globalization;
using System.Threading;

class SumNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double firstNumber;
        bool parseSuccessFirstNumber = true;

        do
        {
            Console.Write("Please enter your first number: ");
            string value = Console.ReadLine();
            parseSuccessFirstNumber = Double.TryParse(value, out firstNumber);
        }
        while (parseSuccessFirstNumber == false);

        double secondNumber;
        bool parseSuccessSecondNumber = true;

        do
        {
            Console.Write("Please enter your second number: ");
            string value = Console.ReadLine();
            parseSuccessSecondNumber = Double.TryParse(value, out secondNumber);
        }
        while (parseSuccessSecondNumber == false);

        double thirdNumber;
        bool parseSuccessThirdNumber = true;

        do
        {
            Console.Write("Please enter your first number: ");
            string value = Console.ReadLine();
            parseSuccessThirdNumber = Double.TryParse(value, out thirdNumber);
        }
        while (parseSuccessThirdNumber == false);

        double sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum is: {0}", sum);
    }
}

