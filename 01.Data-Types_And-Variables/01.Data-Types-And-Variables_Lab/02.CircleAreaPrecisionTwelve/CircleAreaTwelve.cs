using System;

namespace _02.CircleAreaPrecisionTwelve
{
    class CircleAreaTwelve
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:f12}");
        }
    }
}
