/*
Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/

using System;

class FindingTheValueOfTheBit
{
    const int position = 3;
    static void Main()
    {
        int number;
        bool parseSuccess = true;

        do
        {
            Console.Write("Please enter a positive integer: ");
            string value = Console.ReadLine();
            parseSuccess = Int32.TryParse(value, out number);
        }
        while (parseSuccess == false || number < 0);

        Console.WriteLine("Your integer in binary: " + (Convert.ToString(number, 2).PadLeft(16, '0')) + ".");

        int mask = 1 << position;
        int result = number & mask;
        int bit = result >> position;
        Console.WriteLine("The value of the bit at position 3 is {0} ", bit);
    }
}

