/*
Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
*/

using System;

class FindTheFirstLargerThanHeighbours
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

        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (CheckIsLargerThanNeighbours(array, i))
            {
                Console.WriteLine("The index of the first element in the array that is larger than its neighbours is {0}.", i);
                counter++;
                break;
            }
        }

        if (counter == 0)
        {
            Console.WriteLine(-1);
        }
    }
}

