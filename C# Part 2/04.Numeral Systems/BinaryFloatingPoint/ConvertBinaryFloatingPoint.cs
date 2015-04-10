/*
Problem 9.* Binary floating-point

Write a program that shows the internal binary representation of given 32-bit signed floating-point 
number in IEEE 754 format (the C# type float).

Example:

number	    sign	    exponent	    mantissa
-27.25	    1	        10000011	    10110100000000000000000
*/

using System;
using System.Threading;
using System.Globalization;
using System.Linq;

class ConvertBinaryFloatingPoint
{
    static string ConvertFloatingPointNumberToBinary(float floatingPointNUmber)
    {
        int number = BitConverter.ToInt32(BitConverter.GetBytes(floatingPointNUmber), 0);
        return Convert.ToString(number, 2); // Convert to binary

    }
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please enter a 32-bit signed floating-point number: ");
        float number = Single.Parse(Console.ReadLine());

        string sign = string.Empty;

        // get the sign
        if (number > 0)
        {
            sign = "0";
        }
        else if (number < 0)
        {
            sign = "1";
        }

        ConvertFloatingPointNumberToBinary(number);

        string exponent = ConvertFloatingPointNumberToBinary(number).Substring(1, 8);
        string mantissa = ConvertFloatingPointNumberToBinary(number).Substring(9);

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Your number {0} in binary is {1}{2}{3}", number, sign, exponent, mantissa);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Sign: {0}", sign);
        Console.WriteLine("Exponent: {0}", exponent);
        Console.WriteLine("Mantissa: {0}", mantissa);
        Console.WriteLine(new string('-', 50));
    }
}

