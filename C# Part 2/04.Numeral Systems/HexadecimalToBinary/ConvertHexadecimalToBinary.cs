/*
Problem 5. Hexadecimal to binary

Write a program to convert hexadecimal numbers to binary numbers (directly).
*/

using System;
using System.Text;

class ConvertHexadecimalToBinary
{
    static string ConvertToBinary(string number)
    {
        string numberInBinary = string.Empty;

        for (int index = 0; index < number.Length; index++)
        {
            if (char.IsDigit(number[index]))
            {
                switch (number[index])
                {
                    case '0':
                        numberInBinary += "0000";
                        break;
                    case '1':
                        numberInBinary += "0001";
                        break;
                    case '2':
                        numberInBinary += "0010";
                        break;
                    case '3':
                        numberInBinary += "0011";
                        break;
                    case '4':
                        numberInBinary += "0100";
                        break;
                    case '5':
                        numberInBinary += "0101";
                        break;
                    case '6':
                        numberInBinary += "0110";
                        break;
                    case '7':
                        numberInBinary += "0111";
                        break;
                    case '8':
                        numberInBinary += "1000";
                        break;
                    case '9':
                        numberInBinary += "1001";
                        break;
                }

            }
            else if (number[index] >= 65 && number[index] <= 70)
            {
                switch (number[index])
                {
                    case 'A':
                        numberInBinary += "1010";
                        break;
                    case 'B':
                        numberInBinary += "1011";
                        break;
                    case 'C':
                        numberInBinary += "1100";
                        break;
                    case 'D':
                        numberInBinary += "1101";
                        break;
                    case 'E':
                        numberInBinary += "1110";
                        break;
                    case 'F':
                        numberInBinary += "1111";
                        break;
                }
            }
            else
            {
                switch (number[index])
                {
                    case 'a':
                        numberInBinary += "1010";
                        break;
                    case 'b':
                        numberInBinary += "1011";
                        break;
                    case 'c':
                        numberInBinary += "1100";
                        break;
                    case 'd':
                        numberInBinary += "1101";
                        break;
                    case 'e':
                        numberInBinary += "1110";
                        break;
                    case 'f':
                        numberInBinary += "1111";
                        break;
                }
            }
        }
        return numberInBinary;
    }
    
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string hexaNumber = Console.ReadLine();

        Console.Write("Your number in binary: ");
        string numberInBinary = ConvertToBinary(hexaNumber);
        
        Console.WriteLine(numberInBinary);
    }
}


