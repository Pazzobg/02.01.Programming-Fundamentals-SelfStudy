using System;

namespace _09.TriangleFormations
{
    class TriangleFormations
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            bool valid = false;
            bool rightAtSideAB = false;
            bool rightAtSideBC = false;
            bool rightAtSideCA = false;

            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2)) rightAtSideAB = true;
            if (Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2)) rightAtSideBC = true;
            if (Math.Pow(sideC, 2) + Math.Pow(sideA, 2) == Math.Pow(sideB, 2)) rightAtSideCA = true;


            if (sideA + sideB > sideC && sideB + sideC > sideA && sideC + sideA > sideB)
            {
                valid = true;
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }

            if (valid == true && rightAtSideAB == true)
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (valid == true && rightAtSideBC == true)
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (valid == true && rightAtSideCA == true)
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else if (valid == true)
            {
                Console.WriteLine("Triangle has no right angles");
            }
        }
    }
}
