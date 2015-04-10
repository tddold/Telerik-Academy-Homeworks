/*
Problem 11.* Number as Words

Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
*/

using System;

class PrintNumberWithWords
{
    private static void PrintHundreds(int number)
    {
        switch (number / 100)
        {
            case 0:
                break;
            case 1:
                if (number % 100 == 00)
                {
                    Console.WriteLine("One hundred ");
                }
                else
                {
                    Console.Write("One hundred and ");
                }
                break;
            case 2:
                if (number % 100 == 00)
                {
                    Console.WriteLine("Two hundred ");
                }
                else
                {
                    Console.Write("Two hundred and ");
                }
                break;
            case 3:
                if (number % 100 == 00)
                {
                    Console.WriteLine("Three hundred ");
                }
                else
                {
                    Console.Write("Three hundred and ");
                }
                break;
            case 4:
                if (number % 100 == 00)
                {
                    Console.WriteLine("Four hundred ");
                }
                else
                {
                    Console.Write("Four hundred and ");
                }
                break;
            case 5:
                if (number % 100 == 00)
                {
                    Console.WriteLine("Five hundred ");
                }
                else
                {
                    Console.Write("Five hundred and ");
                }
                break;
            case 6:
                if (number % 100 == 00)
                {
                    Console.WriteLine("Six hundred ");
                }
                else
                {
                    Console.Write("Six hundred and ");
                }
                break;
            case 7:
                if (number % 100 == 00)
                {
                    Console.WriteLine("Seven hundred ");
                }
                else
                {
                    Console.Write("Seven hundred and ");
                }
                break;
            case 8:
                if (number % 100 == 00)
                {
                    Console.WriteLine("Eight hundred ");
                }
                else
                {
                    Console.Write("Eight hundred and ");
                }
                break;
            case 9:
                if (number % 100 == 00)
                {
                    Console.WriteLine("Nine hundred ");
                }
                else
                {
                    Console.Write("Nine hundred and ");
                }
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }

    private static void PrintTenths(int number)
    {
        switch ((number / 10) % 10)
        {
            case 0:
                break;
            case 1:
                {
                    switch (number % 10)
                    {
                        case 0:
                            Console.WriteLine("Ten ");
                            break;
                        case 1:
                            Console.WriteLine("Eleven ");
                            break;
                        case 2:
                            Console.WriteLine("Twelve ");
                            break;
                        case 3:
                            Console.WriteLine("Thirteen ");
                            break;
                        case 4:
                            Console.WriteLine("Fourteen ");
                            break;
                        case 5:
                            Console.WriteLine("Fifteen ");
                            break;
                        case 6:
                            Console.WriteLine("Sixteen ");
                            break;
                        case 7:
                            Console.WriteLine("Seventeen ");
                            break;
                        case 8:
                            Console.WriteLine("Eighteen");
                            break;
                        case 9:
                            Console.WriteLine("Nineteen ");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
                break;
            case 2:
                if (number % 10 == 0)
                {
                    Console.WriteLine("Twenty ");
                }
                else
                {
                    Console.Write("Twenty ");
                }

                break;
            case 3:
                if (number % 10 == 0)
                {
                    Console.WriteLine("Thirty ");
                }
                else
                {
                    Console.Write("Thirty ");
                }
                break;
            case 4:
                if (number % 10 == 0)
                {
                    Console.WriteLine("Forty ");
                }
                else
                {
                    Console.Write("Forty ");
                }
                break;
            case 5:
                if (number % 10 == 0)
                {
                    Console.WriteLine("Fifty ");
                }
                else
                {
                    Console.Write("Fifty ");
                }
                break;
            case 6:
                if (number % 10 == 0)
                {
                    Console.WriteLine("Sixty ");
                }
                else
                {
                    Console.Write("Sixty ");
                }
                break;
            case 7:
                if (number % 10 == 0)
                {
                    Console.WriteLine("Seventy ");
                }
                else
                {
                    Console.Write("Seventy ");
                }
                break;
            case 8:
                if (number % 10 == 0)
                {
                    Console.WriteLine("Eighty ");
                }
                else
                {
                    Console.Write("Eighty ");
                }
                break;
            case 9:
                if (number % 10 == 0)
                {
                    Console.WriteLine("Ninety ");
                }
                else
                {
                    Console.Write("Ninety ");
                }
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }

    private static void PrintUnits(int number)
    {
        switch (number % 10)
        {
            case 0:
                if (number / 10 == 0)
                {
                    Console.WriteLine("Zero ");
                }
                break;
            case 1:
                if ((number / 10) % 10 != 1)
                {
                    Console.WriteLine("One ");
                }
                break;
            case 2:
                if ((number / 10) % 10 != 1)
                {
                    Console.WriteLine("Two ");
                }
                break;
            case 3:
                if ((number / 10) % 10 != 1)
                {
                    Console.WriteLine("Three ");
                }
                break;
            case 4:
                if ((number / 10) % 10 != 1)
                {
                    Console.WriteLine("Four ");
                }
                break;
            case 5:
                if ((number / 10) % 10 != 1)
                {
                    Console.WriteLine("Five ");
                }
                break;
            case 6:
                if ((number / 10) % 10 != 1)
                {
                    Console.WriteLine("Six ");
                }
                break;
            case 7:
                if ((number / 10) % 10 != 1)
                {
                    Console.WriteLine("Seven ");
                }
                break;
            case 8:
                if ((number / 10) % 10 != 1)
                {
                    Console.WriteLine("Eight ");
                }
                break;
            case 9:
                if ((number / 10) % 10 != 1)
                {
                    Console.WriteLine("Nine ");
                }
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    static void Main()
    {
        int number;
        bool parseSuccessNumber = true;

        do
        {
            Console.Write("Please enter a number between 0 and 999: ");
            string value = Console.ReadLine();
            parseSuccessNumber = Int32.TryParse(value, out number);
        }
        while (parseSuccessNumber == false || number < 0 || number > 999);

        PrintHundreds(number);
        PrintTenths(number);
        PrintUnits(number);
    }
}

