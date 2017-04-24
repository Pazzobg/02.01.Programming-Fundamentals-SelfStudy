using System;

namespace _12.RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine(2 * (sideA + sideB));     //Perimeter
            Console.WriteLine(sideA * sideB);           //Area
            Console.WriteLine(Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));  //Diagonal
        }
    }
}
