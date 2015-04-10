/*
Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
*/

using System;

class CheckIsLarger
{
    static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static bool CheckIsLargerThanNeighbours(int[] array, int position)
    {
        bool isLarger;

        if (position == 0)
        {
            isLarger = false;
        }
        else if (position == array.Length - 1)
        {
            isLarger = false;
        }
        else
        {
            isLarger = (array[position] > array[position - 1] && array[position] > array[position + 1]);
        }

        return isLarger;
    }

    static void Main()
    {
        Console.Write("Please enter a positive integer for the length of your array: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        Console.WriteLine("Please now enter the elements of your array:");
        FillArray(array);

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Your array: {0}", string.Join(", ", array));
        Console.WriteLine(new string('-', 50));

        Console.Write("Enter the position of the element you want to check: ");

        int position;
        string value = Console.ReadLine();
        bool parseSuccess = int.TryParse(value, out position);

        while (parseSuccess == false || position < 0 || position > array.Length - 1)
        {
            Console.Write("Wrong position. Please try again: ");
            value = Console.ReadLine();
            parseSuccess = int.TryParse(value, out position);
        }

        bool isLarger = CheckIsLargerThanNeighbours(array, position);
        Console.WriteLine("The element at position {0} is larger than its two neighbours: {1}",position, isLarger);
    }
}

