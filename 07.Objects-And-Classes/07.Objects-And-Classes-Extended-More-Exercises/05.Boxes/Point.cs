namespace _05.Boxes
{
    using System;
    
    public class Point
    {
        int X { get; set; }
        int Y { get; set; }

        public static int CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = firstPoint.X - secondPoint.X;
            double sideB = firstPoint.Y - secondPoint.Y;

            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return (int)distance;
        }
    }
}
