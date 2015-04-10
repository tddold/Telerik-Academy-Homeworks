/*
Problem 8. Catalan Numbers

Write a program to calculate the nth Catalan number by given n (1 < n < 100).
*/

using System;
using System.Numerics;

class PrintTheNthCatalanNumber
{
    static void Main()
    {
        int number;
        bool parseSuccessN = true;

        do
        {
            Console.Write("Please enter a number N (1 - 100): ");
            string value = Console.ReadLine();
            parseSuccessN = Int32.TryParse(value, out number);
        }
        while (parseSuccessN == false || number <= 1 || number >= 100);

        BigInteger a = 1;
        BigInteger b = 1;
        BigInteger c = 1;
        BigInteger result = 0;

        for (int currentNumber = 1; currentNumber <= (2 * number); currentNumber++)
        {
            a *= currentNumber;

            if (currentNumber <= (number + 1))
            {
                b *= currentNumber;
            }
            if (currentNumber <= number)
            {
                c *= currentNumber;
            }
        }
        result = a / (b * c);
        Console.WriteLine("The {0}th Catalan number is {1}", number, result);
    }
}

