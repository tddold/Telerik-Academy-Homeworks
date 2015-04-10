/*
Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
Note: You may need to use a for-loop.
*/

using System;
using System.Globalization;
using System.Threading;

class CalculateAndPrintSumOfNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int number;
        bool parseSuccessNumber = true;

        do
        {
            Console.Write("Please enter a positive number: ");
            string value = Console.ReadLine();
            parseSuccessNumber = Int32.TryParse(value, out number);
        }
        while (parseSuccessNumber == false || number <= 0);

        Console.WriteLine("Now please enter {0} numbers to calculate their sum:", number);

        double sum = 0;
        double numberSequence;
        bool parseSuccessNumberTwo = true;

        for (int index = 0; index < number; index++)
        {
            do
            {
                Console.Write("Enter number: ");
                string value = Console.ReadLine();
                parseSuccessNumberTwo = Double.TryParse(value, out numberSequence);
            }
            while (parseSuccessNumberTwo == false);
            sum += numberSequence;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}

