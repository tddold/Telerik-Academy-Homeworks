/*
Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the 
rectangle R(top=1, left=-1, width=6, height=2).
*/

using System;
using System.Globalization;
using System.Threading;

class CheckPoint
{
    static void Main()
    {
         Console.WriteLine("Please enter the coordinates of your point.");

         double numberX;
         bool parseSuccessX = true;

         do
         {
             Console.Write("Enter x: ");
             string value = Console.ReadLine();
             parseSuccessX = Double.TryParse(value, out numberX);
         }
         while (parseSuccessX == false);

         double numberY;
         bool parseSuccessY = true;

         do
         {
             Console.Write("Enter y: ");
             string value = Console.ReadLine();
             parseSuccessY = Double.TryParse(value, out numberY);
         }
         while (parseSuccessY == false);

         bool checkCircle = ((numberX - 1) * (numberX - 1) + (numberY - 1) * (numberY - 1)) <= 1.5 * 1.5; 
         bool checkRectangle = numberX < -1 || numberX > 5 || numberY < -1 || numberY > 1; 
         bool isTrue = checkCircle && checkRectangle;
         Console.WriteLine("Your point is within the circle and out of the rectangle - {0} ", isTrue);
       
    }
}

