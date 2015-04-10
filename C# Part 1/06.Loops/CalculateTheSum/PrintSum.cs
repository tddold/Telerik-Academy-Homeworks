/*
Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
Use only one loop. Print the result with 5 digits after the decimal point.
*/

using System;
using System.Numerics;

class PrintSum
{
    static void Main()
    {
        int n;
        bool parseSuccessN = true;

        do
        {
            Console.Write("Please enter a positive integer N: ");
            string value = Console.ReadLine();
            parseSuccessN = Int32.TryParse(value, out n);
        }
        while (parseSuccessN == false);

        int x;
        bool parseSuccessX = true;

        do
        {
            Console.Write("Please enter a positive number X: ");
            string value = Console.ReadLine();
            parseSuccessX = Int32.TryParse(value, out x);
        }
        while (parseSuccessX == false);


        double sum = 0;
        BigInteger factorial = 1;
        double calculateExponent = 0;
        
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            calculateExponent = Math.Pow(x, i);
            sum += ((double)factorial / calculateExponent);
        }

        Console.WriteLine("The sum is: {0:F5}", sum + 1);
    }
}

