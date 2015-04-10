/*
Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.
*/

using System;

class ExtractTheValueOfBit
{
    static void Main()
    {
        int number;
        bool parseSuccessNumber = true;

        do
        {
            Console.Write("Please enter a positive integer: ");
            string value = Console.ReadLine();
            parseSuccessNumber = Int32.TryParse(value, out number);
        }
        while (parseSuccessNumber == false || number < 0);

        Console.WriteLine("Your integer in binary: " + (Convert.ToString(number, 2).PadLeft(16, '0')));

        int position;
        bool parseSuccessPosition = true;

        do
        {
            Console.Write("Please enter a positive position: ");
            string value = Console.ReadLine();
            parseSuccessPosition = Int32.TryParse(value, out position);
        }
        while (parseSuccessPosition == false || position < 0);

        int mask = 1 << position;
        int result = mask & number;
        int bit = result >> position;

        Console.WriteLine("The value of the bit at position {0} is {1} ", position, bit);
    }
}

