/*
Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
*/

using System;

class CountAppearanceOfNumber
{
    static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static int CountAppearance(int[] array, int number)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("Please enter the length of your array: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Please enter a number to check how many times its appears in the array: ");
        int number = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        Console.WriteLine("Please enter the elements of your array:");
        FillArray(array);

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Your array: {0}", string.Join(", ", array));

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Your number ({0}) appears {1} times in the array.", number, CountAppearance(array, number));
    }
}

