/*
Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
*/

using System;
using System.Threading;
using System.Globalization;

class CompareTwoNumbers
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

        Console.WriteLine(firstNumber > secondNumber ? "The greater number is {0}" : "The greater number is {1}", firstNumber, secondNumber);
    }
}

