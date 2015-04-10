/*
Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
*/

using System;
using System.Numerics;

class PrintResultOfMathematicalExpression
{
    static void Main()
    {
        int n;
        bool parseSuccessN = true;

        do
        {
            Console.Write("Please enter a number N (1 - 100): ");
            string value = Console.ReadLine();
            parseSuccessN = Int32.TryParse(value, out n);
        }
        while (parseSuccessN == false || n <= 1 || n >= 100);

        int k;
        bool parseSuccessK = true;

        do
        {
            Console.Write("PLease enter a number K which is between 1 and {0}: ", n);
            string value = Console.ReadLine();
            parseSuccessK = Int32.TryParse(value, out k);
        }
        while (parseSuccessK == false || k <= 1 || k >= n);

        BigInteger factorialOfN = 1;
        BigInteger factorialOfK = 1;
        BigInteger result = 0;

        for (int i = 1; i <= n; i++)
        {
            factorialOfN *= i;
            if (i <= k)
            {
                factorialOfK *= i;
            }
        }
        result = factorialOfN / factorialOfK;
        Console.WriteLine("The result is {0}", result);
    }
}

