/*
Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
*/

using System;

class ConvertDecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number: ");
        int number = Int32.Parse(Console.ReadLine());

        while (number < 0)
        {
            Console.Write("You need to enter postive number: ");
            number = Int32.Parse(Console.ReadLine());
        }
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
        Console.WriteLine("Your number in binary: {0}", reverseNumberBit.PadLeft(32, '0'));
    }
}

