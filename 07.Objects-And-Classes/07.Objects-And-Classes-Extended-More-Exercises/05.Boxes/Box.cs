using System;

namespace _05.Boxes
{
    public class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }
        public double Width => CalculateDistance(UpperLeft, UpperRight);
        public double Height => CalculateDistance(UpperLeft, BottomLeft);

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = (double)firstPoint.X - secondPoint.X;
            double sideB = (double)firstPoint.Y - secondPoint.Y;

            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return distance;
        }
    }
}
