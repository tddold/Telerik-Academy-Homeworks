/*
Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
As a result print the values a and b, separated by a space.
*/

using System;
using System.Globalization;
using System.Threading;

class ExchangeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double firstNumber;
        bool parseSuccessFirstNumber = true;

        do
        {
            Console.Write("Please enter your first number A: ");
            string value = Console.ReadLine();
            parseSuccessFirstNumber = Double.TryParse(value, out firstNumber);
        }
        while (parseSuccessFirstNumber == false);

        double secondNumber;
        bool parseSuccessSecondNumber = true;

        do
        {
            Console.Write("Please enter your second number B: ");
            string value = Console.ReadLine();
            parseSuccessSecondNumber = Double.TryParse(value, out secondNumber);
        }
        while (parseSuccessSecondNumber == false);

        if (firstNumber > secondNumber)
        {
            double help = firstNumber;
            firstNumber = secondNumber;
            secondNumber = help;

            Console.WriteLine("Your first number is greater than your second.\nI can exchange their values. After exchange A = {0} B = {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("Your first number isn't greater than your second. I can't exchange their values. A = {0} B = {1}", firstNumber, secondNumber);
        }
    }
}

