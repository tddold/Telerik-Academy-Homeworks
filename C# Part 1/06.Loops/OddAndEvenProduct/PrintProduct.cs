/*
Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;

class PrintProduct
{
    static void Main()
    {
        Console.Write("Please enter your numbers in a single line, separated by a space: ");
        string number = Console.ReadLine();

        string[] numberArray = number.Split(' ');

        int[] numbers = new int[numberArray.Length];

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = Int32.Parse(numberArray[index]);
        }

        int oddProduct = 1;
        int evenProduct = 1;

        for (int position = 0; position <numbers.Length; position++)
        {
            if (position % 2 != 0)
            {
                oddProduct *= numbers[position];
            }
            else
            {
                evenProduct *= numbers[position];
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("The product of the odd elements is equal to the product of the even elements. Product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("The product of the odd elements isn't equal to the product of the even elements.");
            Console.WriteLine("The product of the odd elements is {0} and the product of the even elements is {1}.", oddProduct, evenProduct);
        }
    }
}

