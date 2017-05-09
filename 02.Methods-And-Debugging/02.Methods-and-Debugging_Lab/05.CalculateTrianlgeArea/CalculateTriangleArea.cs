namespace _05.CalculateTrianlgeArea
{
    using System;

    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double sideH = double.Parse(Console.ReadLine());

            double area = CalculateArea(side, sideH);

            Console.WriteLine(area);
        }

        public static double CalculateArea(double a, double ha)
        {
            return (a * ha) / 2;
        }
    }
}
