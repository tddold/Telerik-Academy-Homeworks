/*
Problem 8. Binary short

Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/

using System;
using System.Linq;

class BinaryRepresentation
{
    static string ReverseNumber(string number)
    {
        string result = string.Empty;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            result += number[i];
        }
        return result;
    }

    static string ShortToBin(int number, string result)
    {
        short resultNumber = 0;
        while (number != 0)
        {
            resultNumber = Math.Abs((short)(number / 2));
            result = (Math.Abs(number % 2)).ToString() + result;
            number = resultNumber;
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Please enter a number of type short. Your number must be between {0} and {1}: ", short.MinValue, short.MaxValue);

        short number;
        string value = Console.ReadLine();
        bool parseSuccess = short.TryParse(value, out number);

        while (parseSuccess == false || number < short.MinValue || number > short.MaxValue)
        {
            Console.Write("Invalid number. Please try again: ");
            value = Console.ReadLine();
            parseSuccess = short.TryParse(value, out number);
        }

        string result = string.Empty;
        int num = 0;
        //string num = ShortToBin(number, result);
        
        if (number < 0)
        {
            num = (short)(short.MinValue ^ number);
            result = "1" + ShortToBin(num, result).PadLeft(15, '0');
        }
        else if (number > 0)
        {
            result = ShortToBin(number, result).PadLeft(16, '0');
        }
        else
        {
            result = "0";
        }

        Console.WriteLine("Your number in binary: {0}", result);

    }
}

