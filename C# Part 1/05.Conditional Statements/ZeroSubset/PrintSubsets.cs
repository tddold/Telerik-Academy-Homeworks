/*
Problem 12.* Zero Subset

We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.
*/

using System;

class PrintSubsets
{
    static void Main()
    {
        Console.WriteLine("Please enter five integer numbers.");
        Console.Write("Number 1: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("Number 2: ");
        int b = Int32.Parse(Console.ReadLine());
        Console.Write("Number 3: ");
        int c = Int32.Parse(Console.ReadLine());
        Console.Write("Number 4: ");
        int d = Int32.Parse(Console.ReadLine());
        Console.Write("Number 5: ");
        int e = Int32.Parse(Console.ReadLine());

        int counter = 0;

        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, b);
            counter++;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
            counter++;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
            counter++;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
            counter++;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            counter++;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            counter++;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            counter++;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            counter++;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            counter++;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            counter++;
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            counter++;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            counter++;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            counter++;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, c);
            counter++;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, d);
            counter++;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, e);
            counter++;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            counter++;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            counter++;
        }

        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            counter++;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            counter++;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
            counter++;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
            counter++;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
            counter++;
        }
        if (counter == 0)
        {
            Console.WriteLine("No zero subset");
        }
    }
}

