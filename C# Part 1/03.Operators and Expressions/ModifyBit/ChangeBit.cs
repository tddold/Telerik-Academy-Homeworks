/*
Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation 
of n while preserving all other bits in n.
*/

using System;

class ChangeBit
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

        Console.WriteLine("Your integer in binary: " + (Convert.ToString(number, 2).PadLeft(32, '0')));

        int position;
        bool parseSuccessPosition = true;

        do
        {
            Console.Write("Please enter a positive position: ");
            string value = Console.ReadLine();
            parseSuccessPosition = Int32.TryParse(value, out position);
        }
        while (parseSuccessPosition == false || position < 0);

        int bitValue;
        bool parseSuccessBitValue = true;
        bool isCorrectBitValue = false;

        do
        {
            Console.Write("Please enter a bit value (choose 1 or 0): ");
            string value = Console.ReadLine();
            parseSuccessBitValue = Int32.TryParse(value, out bitValue);
            isCorrectBitValue = bitValue == 0 || bitValue == 1;
        }
        while (parseSuccessBitValue == false || !isCorrectBitValue);

        if (bitValue == 0)
        {
            int result = (~(1 << position) & number);
            Console.WriteLine("The answer is: {0} or {1} in decimal", Convert.ToString(result, 2).PadLeft(16, '0'), result);
        }

        if (bitValue == 1)
        {
            int resultOne = number | (1 << position);
            Console.WriteLine("The answer is: {0} or {1} in decimal", Convert.ToString(resultOne, 2).PadLeft(16, '0'), resultOne);
        }
    }
}



