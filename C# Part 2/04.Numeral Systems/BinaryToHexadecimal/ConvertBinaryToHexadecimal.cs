/*
Problem 6. binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).
*/

using System;
using System.Text;

class ConvertBinaryToHexadecimal
{
    static string FillWithZeros(string number)
    {
        string newBinaryNumber = string.Empty;
        switch (number.Length % 4)
        {
            case 0:
                newBinaryNumber = number;
                break;
            case 1:
                newBinaryNumber = number.PadLeft(number.Length + 3, '0');
                break;
            case 2:
                newBinaryNumber = number.PadLeft(number.Length + 2, '0');
                break;
            case 3:
                newBinaryNumber = number.PadLeft(number.Length + 1, '0');
                break;
        }

        return newBinaryNumber;
    }
    static string ConvertToHexadecimal(string binaryNumber)
    {
        StringBuilder numberInHexadecimal = new StringBuilder();

        for (int i = 0; i < binaryNumber.Length; i = i + 4)
        {
            switch (binaryNumber.Substring(i, 4))
            {
                case "0000":
                    numberInHexadecimal.Append(0);
                    break;
                case "0001":
                    numberInHexadecimal.Append(1);
                    break;
                case "0010":
                    numberInHexadecimal.Append(2);
                    break;
                case "0011":
                    numberInHexadecimal.Append(3);
                    break;
                case "0100":
                    numberInHexadecimal.Append(4);
                    break;
                case "0101":
                    numberInHexadecimal.Append(5);
                    break;
                case "0110":
                    numberInHexadecimal.Append(6);
                    break;
                case "0111":
                    numberInHexadecimal.Append(7);
                    break;
                case "1000":
                    numberInHexadecimal.Append(8);
                    break;
                case "1001":
                    numberInHexadecimal.Append(9);
                    break;
                case "1010":
                    numberInHexadecimal.Append("A");
                    break;
                case "1011":
                    numberInHexadecimal.Append("B");
                    break;
                case "1100":
                    numberInHexadecimal.Append("C");
                    break;
                case "1101":
                    numberInHexadecimal.Append("D");
                    break;
                case "1110":
                    numberInHexadecimal.Append("E");
                    break;
                case "1111":
                    numberInHexadecimal.Append("F");
                    break;
            }
        }
        return numberInHexadecimal.ToString();
    }
    static void Main()
    {
        Console.Write("Enter you binary number: ");
        string binaryNumber = Console.ReadLine();

        string newBinaryNumber = FillWithZeros(binaryNumber);
        
        Console.WriteLine("Your number in hexadecimal: {0}", ConvertToHexadecimal(newBinaryNumber));
    }
}

