namespace _11.GeometryCalculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            string figureType = Console.ReadLine().ToLower();
            double area = 0;
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = CalculateTriangleArea(side, height);
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());

                area = CalculateSquareArea(side);
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = CalculateRectangleArea(width, height);
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                area = CalculateCircleArea(radius);
            }

            Console.WriteLine($"{area:f2}");
        }

        public static double CalculateTriangleArea(double a, double ha)
        {
            return (a * ha) / 2;
        }

        public static double CalculateSquareArea(double a)
        {
            return a * a;
        }

        public static double CalculateRectangleArea(double a, double b)
        {
            return a * b;
        }

        public static double CalculateCircleArea(double r)
        {
            return Math.PI * r * r;
        }
    }
}
