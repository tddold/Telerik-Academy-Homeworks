/*
Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements
(also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to 
withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/

using System;
using System.Numerics;

class PrintNumberOfCombinations
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

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialExpression = 1;
        BigInteger result = 0;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;

            if (i <= k)
            {
                factorialK *= i;
            }

            if (i <= (n - k))
            {
                factorialExpression *= i;
            }
        }
        result = factorialN / (factorialK * factorialExpression);
        Console.WriteLine("The result is {0}", result);
    }
}

