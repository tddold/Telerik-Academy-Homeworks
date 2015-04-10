/*Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, 
sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

using System;


class UsingMethodBinarySearch
{
    static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Please enter the length of your array: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Please enter a number K: ");
        int number = int.Parse(Console.ReadLine());

        int[] arrayOfIntegers = new int[length];

        Console.WriteLine("Please enter the elements of your array");
        FillArray(arrayOfIntegers);

        Console.WriteLine("Your array before the sort");
        Console.WriteLine(string.Join(", ", arrayOfIntegers));

        Array.Sort(arrayOfIntegers);

        Console.WriteLine("Your array after the sort");
        Console.WriteLine(string.Join(", ", arrayOfIntegers));

        int index = Array.BinarySearch(arrayOfIntegers, number);

        if (index == -1)
        {
            Console.WriteLine("I cant find a number which is ≤ {0}. All number are bigger than {0}.", number);
        }
        else if (index < -1)
        {
            Console.WriteLine("The largest number in the array which is ≤ {1} -> {0}", arrayOfIntegers[Math.Abs(index + 2)], number);
        }
        else
        {
            Console.WriteLine("The largest number in the array which is ≤ {1} -> {0}", arrayOfIntegers[index - 1], number);
        }
    }
}

