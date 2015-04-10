/*
Problem 14. Decimal to Binary Number
 
Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a integer number: ");
        int number = Int32.Parse(Console.ReadLine());
        int result;

        string numberBit = "";

        while (number >= 1)
        {
            result = number / 2;
            numberBit += (number % 2).ToString();
            number = result;
        }

        string reverseNumberBit = "";

        for (int i = numberBit.Length - 1; i >= 0; i--)
        {
            reverseNumberBit += numberBit[i];
        }
        Console.WriteLine("Your number is binary: {0}", reverseNumberBit);
    }
}