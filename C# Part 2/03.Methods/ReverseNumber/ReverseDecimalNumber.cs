/*
Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
*/

using System;
using System.Globalization;
using System.Threading;

class ReverseDecimalNumber
{
    static string ReverseNumber(string number)
    {
        string reverseNumber = string.Empty;

        bool isTrue = true;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (number[0] == '-' && isTrue)
            {
                reverseNumber += "-";
                isTrue = false;
            }

            if (number[i] != '-')
            {
                reverseNumber += number[i].ToString();
            }
        }
        return reverseNumber;
    }
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please enter your decimal number: ");
        string number = Console.ReadLine();

        string reverseNumber = ReverseNumber(number);
        Console.WriteLine("Your reversed decimal number: {0}", reverseNumber);
    }
}

