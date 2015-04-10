/*
Problem 13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given
integer number n, has value of 1.
*/

using System;

class CheckABitOfGivenPosition
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

        if (bit == 1)
        {
            bool isTrue = true;
            Console.WriteLine("The value of your bit is 1 - {0}", isTrue);
        }
        else
        {
            bool isTrue = false;
            Console.WriteLine("The value of your bit is 1 - {0}", isTrue);
        }
    }
}

