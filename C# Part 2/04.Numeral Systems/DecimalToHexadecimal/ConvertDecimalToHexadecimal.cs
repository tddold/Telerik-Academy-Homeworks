/*
Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
*/

using System;
using System.Linq;

class ConvertDecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter a integer number: ");
        ulong number = ulong.Parse(Console.ReadLine());
        ulong result;

        string hexaNumber = String.Empty;

        while (number >= 1)
        {
            result = number / 16;

            switch ((number % 16).ToString())
            {
                case "1":
                    hexaNumber += "1";
                    break;
                case "2":
                    hexaNumber += "2";
                    break;
                case "3":
                    hexaNumber += "3";
                    break;
                case "4":
                    hexaNumber += "4";
                    break;
                case "5":
                    hexaNumber += "5";
                    break;
                case "6":
                    hexaNumber += "6";
                    break;
                case "7":
                    hexaNumber += "7";
                    break;
                case "8":
                    hexaNumber += "8";
                    break;
                case "9":
                    hexaNumber += "9";
                    break;
                case "10":
                    hexaNumber += "A";
                    break;
                case "11":
                    hexaNumber += "B";
                    break;
                case "12":
                    hexaNumber += "C";
                    break;
                case "13":
                    hexaNumber += "D";
                    break;
                case "14":
                    hexaNumber += "E";
                    break;
                case "15":
                    hexaNumber += "F";
                    break;
            }
            number = result;
        }

        string reverseNumber = string.Empty;

        for (int i = hexaNumber.Length - 1; i >= 0; i--)
        {
            reverseNumber += hexaNumber[i];
        }
        Console.WriteLine("Your number is hexadecimal format: {0}", reverseNumber);

    }
}

