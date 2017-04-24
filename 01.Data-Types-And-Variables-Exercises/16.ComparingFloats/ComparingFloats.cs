using System;

namespace _16.Comparingdoubles
{
    class Comparingdoubles
    {
        static void Main(string[] args)
        {
                double numberA = double.Parse(Console.ReadLine());
                double numberB = double.Parse(Console.ReadLine());
                double eps = 0.000001;
                bool equal = false;

                if (Math.Abs(numberA - numberB) < eps)
                {
                    equal = true;
                }
                Console.WriteLine(equal);
        }
    }
}
