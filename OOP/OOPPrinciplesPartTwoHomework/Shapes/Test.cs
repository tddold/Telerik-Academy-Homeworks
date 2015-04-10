namespace Shapes
{
    using System;
    using System.Collections.Generic;

    // Problem 1. Shapes

    // Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    // Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
    // (heightwidth for rectangle and heightwidth/2 for triangle).
    // Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement 
    // the CalculateSurface() method.
    // Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) 
    // stored in an array.
    public class Test
    {
        public static void Main()
        {
            IList<Shape> shapes = new List<Shape>()
            {
                new Rectangle(3, 5),
                new Triangle(3, 7),
                new Square(3)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("The surface of {0} is: {1}", shape.GetType().Name.ToLower(), shape.CalculateSurface());
            }
        }
    }
}
