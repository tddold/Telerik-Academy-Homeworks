/*
Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/

using System;

class FindTheLargestNumber
{
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else if (b > a)
        {
            return b;
        }
        else
        {
            return a;

        }
    }
    static void Main()
    {
        Console.Write("Please enter your first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter your second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter your third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggest number is: {0}", GetMax(GetMax(firstNumber, secondNumber), thirdNumber));

    }
}

