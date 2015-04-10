/*
Problem 9. Exchange Variable Values

Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.
*/

using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        int sum = a + b;
        int newA = sum - a;
        int newB = sum - b;

        Console.WriteLine("Before exchange a = {0} and b = {1}. After exchange a = {2} and b = {3}", a, b, newA, newB);
    }
}

