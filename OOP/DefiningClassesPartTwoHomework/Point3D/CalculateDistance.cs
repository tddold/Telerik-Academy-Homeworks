namespace Point3D
{
    using System;

    public static class CalculateDistance
    {
        public static double CalculateDistanceOfTwoPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double coordinatesX = (firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X);
            double coordinatesY = (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y);
            double coordinatesZ = (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z);

            return Math.Sqrt(coordinatesX + coordinatesY + coordinatesZ);
        }
    }
}
