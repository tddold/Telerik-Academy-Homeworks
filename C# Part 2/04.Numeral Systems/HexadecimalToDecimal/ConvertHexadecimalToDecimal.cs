/*
Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.
*/

using System;

class ConvertHexadecimalToDecimal
{
    static void Main()
    {

        Console.Write("Please enter a hexadecimal number: ");
        string hexaNumber = Console.ReadLine();

        char[] numbers = new char[hexaNumber.Length];

        int position = 0;

        foreach (char element in hexaNumber)
        {
            numbers[position] = element;
            position++;
        }

        char[] reverseNumbers = new char[numbers.Length];

        int positionReverse = 0;
        for (int index = numbers.Length - 1; index >= 0; index--)
        {
            reverseNumbers[positionReverse] = (numbers[index]);
            positionReverse++;
        }

        long numberInDecimal = 0;

        Console.Write("Your number in decimal: ");

        for (int index = 0; index < reverseNumbers.Length; index++)
        {
            if (char.IsDigit(reverseNumbers[index]))
            {
                numberInDecimal += (long)Math.Pow(16, index) * (reverseNumbers[index] - '0');
            }
            else if (reverseNumbers[index] >= 65 && reverseNumbers[index] <= 70)
            {
                numberInDecimal += (long)Math.Pow(16, index) * (reverseNumbers[index] - 55);
            }
            else
            {
                numberInDecimal += (long)Math.Pow(16, index) * (reverseNumbers[index] - 87);
            }
        }

        Console.WriteLine(numberInDecimal);
    }
}

