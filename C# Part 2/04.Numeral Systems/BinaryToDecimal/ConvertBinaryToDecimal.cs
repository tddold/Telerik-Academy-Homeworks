/*
Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
*/

using System;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a binary integer number: ");
        string binaryNumber = Console.ReadLine();

        string[] numbers = new string[binaryNumber.Length];

        int position = 0;

        foreach (char element in binaryNumber)
        {
            numbers[position] = element.ToString();
            position++;
        }

        long[] reverseNumbers = new long[numbers.Length];

        int positionReverse = 0;
        for (int index = numbers.Length - 1; index >= 0; index--)
        {
            reverseNumbers[positionReverse] = Int32.Parse((numbers[index]));
            positionReverse++;
        }

        long numberInDecimal = 0;

        Console.Write("Your number in decimal: ");

        for (int index = 0; index < reverseNumbers.Length; index++)
        {
            numberInDecimal += (long)Math.Pow(2, index) * reverseNumbers[index];
        }

        Console.WriteLine(numberInDecimal);

    }
}

