/*
Problem 15.* Bits Exchange

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
*/

using System;

class ChangeBits
{
    static void Main()
    {
        ulong number;
        bool parseSuccessNumber = true;

        do
        {
            Console.Write("Please enter a positive integer: ");
            string value = Console.ReadLine();
            parseSuccessNumber = ulong.TryParse(value, out number);
        }
        while (parseSuccessNumber == false || number < 0);

        Console.WriteLine("Your integer before the exchange: {0}", number);

        for (int firstPosition = 3, secondPosition = 24; firstPosition < 6; firstPosition++, secondPosition++)
        {
            if (((number >> firstPosition) & 1) != ((number >> secondPosition) & 1))
            {
                number = number ^ (ulong)(1 << firstPosition);
                number = number ^ (ulong)(1 << secondPosition);
            }
        }
        Console.WriteLine("Your integer after the exchange: {0}", number);
    }
}

