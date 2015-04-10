/*
Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
*/

using System;
using System.Linq;

class PrintString
{
    static void Main()
    {
        Console.Write("Please enter your string: ");
        string text = Console.ReadLine();

        string reversedText = string.Empty;

        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedText += text[i];
        }
        Console.WriteLine("Your reversed string is -> {0}", reversedText);
    }
}

