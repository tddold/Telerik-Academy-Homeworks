/*
Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
 */

using System;

class IsTruePlayCardCheck
{
    static void Main()
    {
        Console.Write("Please enter card sign: ");
        string sign = Console.ReadLine();

        switch (sign)
        {
            case "2":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "3":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "4":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "5":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "6":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "7":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "8":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "9":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "J":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "Q":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "K":
                Console.WriteLine("Valid card sign - Yes");
                break;
            case "A":
                Console.WriteLine("Valid card sign - Yes");
                break;
            default:
                Console.WriteLine("Valid card sign - No");
                break;
        }
    }
}

