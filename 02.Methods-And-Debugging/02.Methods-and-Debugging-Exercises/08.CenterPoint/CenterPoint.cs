namespace _08.CenterPodouble
{
    using System;

    public class CenterPodouble
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PointCloserToCenter(x1, y1, x2, y2);
        }

        public static void PointCloserToCenter(double x1, double y1, double x2, double y2)
        {
            double closerFirstPodouble = Math.Abs(x1) + Math.Abs(y1);
            double closerSecondPodouble = Math.Abs(x2) + Math.Abs(y2);

            if (closerFirstPodouble <= closerSecondPodouble)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
