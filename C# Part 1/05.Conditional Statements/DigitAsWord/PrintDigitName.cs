/*
Problem 8. Digit as Word

Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
*/

using System;

class PrintDigitName
{
    static void Main()
    {
        int digit;
        bool parseSuccessDigit = true;

        do
        {
            Console.Write("Enter your digit (0-9): ");
            string value = Console.ReadLine();
            parseSuccessDigit = Int32.TryParse(value, out digit);
        }
        while (parseSuccessDigit == false);

        switch(digit)
        {
            case 0:
                Console.WriteLine("Digit as a word: Zero");
                break;
            case 1:
                Console.WriteLine("Digit as a word: One");
                break;
            case 2:
                Console.WriteLine("Digit as a word: Two");
                break;
            case 3:
                Console.WriteLine("Digit as a word: Three");
                break;
            case 4:
                Console.WriteLine("Digit as a word: Four");
                break;
            case 5:
                Console.WriteLine("Digit as a word: Five");
                break;
            case 6:
                Console.WriteLine("Digit as a word: Six");
                break;
            case 7:
                Console.WriteLine("Digit as a word: Seven");
                break;
            case 8:
                Console.WriteLine("Digit as a word: Eight");
                break;
            case 9:
                Console.WriteLine("Digit as a word: Nine");
                break;
            default:
                Console.WriteLine("Not a digit");
                break;
        }
    }
}

