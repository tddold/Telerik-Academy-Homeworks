/*
Problem 5. Third Digit is 7?

Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/

using System;

class ThirdDigit
{
    static void Main()
    {
        bool isSeven = true;
        string number = Console.ReadLine();

        int check = Int32.Parse(number);
        if(check / 100 == 0)
        {
            Console.WriteLine("Sorry, but your number is too small. I can't check if the third digit from right-to-left is 7.");
            return;
        }

        char[] numberArray = number.ToCharArray();
        string reverse = String.Empty;

        for (int i = numberArray.Length - 1; i > -1; i--)
        {
            reverse += numberArray[i];
        }

        char seven = '7';
        if (reverse[2] == seven)
        {
            isSeven = true;
            Console.WriteLine("The third digit from right-to-left is 7 - {0}", isSeven);
        }
        else
        {
            isSeven = false;
            Console.WriteLine("The third digit from right-to-left is 7 - {0}. It is {1}.", isSeven, reverse[2]);
        }
    }
}

