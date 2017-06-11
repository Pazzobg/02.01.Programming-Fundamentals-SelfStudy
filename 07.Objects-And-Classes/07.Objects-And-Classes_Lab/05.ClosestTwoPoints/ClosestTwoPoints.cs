namespace _05.ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var pointsList = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                int[] currentPointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Point currentPoint = new Point
                {
                    X = currentPointCoordinates[0],
                    Y = currentPointCoordinates[1]
                };

                pointsList.Add(currentPoint);
            }

            double shortestDistance = double.MaxValue;
            Point shortestDistancePointOneCoordinates = null;
            Point shortestDistancePointTwoCoordinates = null;

            for (int i = 0; i < pointsList.Count - 1; i++)
            {
                for (int j = i + 1; j < pointsList.Count; j++)
                {
                    double currentDistance = CalculateDistance(pointsList[i], pointsList[j]);

                    if (currentDistance < shortestDistance)
                    {
                        shortestDistance = currentDistance;
                        shortestDistancePointOneCoordinates = pointsList[i];
                        shortestDistancePointTwoCoordinates = pointsList[j];
                    }
                }
            }

            Console.WriteLine($"{shortestDistance:f3}");
            Console.WriteLine($"({shortestDistancePointOneCoordinates.X}, {shortestDistancePointOneCoordinates.Y})");
            Console.WriteLine($"({shortestDistancePointTwoCoordinates.X}, {shortestDistancePointTwoCoordinates.Y})");
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
