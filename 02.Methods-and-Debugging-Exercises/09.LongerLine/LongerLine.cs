namespace _09.LongerLine
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());

            CalculateLongerLine(x1, y1, x2, y2, a1, b1, a2, b2);
        }

        public static void CalculateLongerLine(double x1, double y1, double x2, double y2, double a1, double b1, double a2, double b2)
        {
            double firstLineLonger = Math.Abs(x1) + Math.Abs(y1) - Math.Abs(x2) + Math.Abs(y2);
            double secondLineLonger = Math.Abs(a1) + Math.Abs(b1) - Math.Abs(a2) + Math.Abs(b2);

            if (firstLineLonger >= secondLineLonger)
            {
                Console.WriteLine(PointCloserToCenter(x1, y1, x2, y2));
            }
            else
            {
                Console.WriteLine(PointCloserToCenter(a1, b1, a2, b2));
            }
        }

        public static string PointCloserToCenter(double x1, double y1, double x2, double y2)
        {
            double closerFirstPoint = Math.Abs(x1) + Math.Abs(y1);
            double closerSecondPoint = Math.Abs(x2) + Math.Abs(y2);

            if (closerFirstPoint <= closerSecondPoint)
            {
                string output = $"({x1}, {y1})({x2}, {y2})";
                return output;
            }
            else
            {
                string output = $"({x2}, {y2})({x1}, {y1})";
                return output;
            }
        }
    }
}
