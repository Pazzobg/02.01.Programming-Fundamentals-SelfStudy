namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            int[] firstPointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondPointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point firstPoint = new Point
            {
                X = firstPointCoordinates[0],
                Y = firstPointCoordinates[1]
            };

            Point secondPoint = new Point
            {
                X = secondPointCoordinates[0],
                Y = secondPointCoordinates[1]
            };

            double result = CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = firstPoint.X - secondPoint.X;
            double sideB = firstPoint.Y - secondPoint.Y;

            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return distance;
        }
    }
}
