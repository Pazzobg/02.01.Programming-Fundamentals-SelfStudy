using System;

namespace _07.FromTerabytesToBits
{
    class FromTBtoBits
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            decimal bits = (decimal)input * (decimal)(Math.Pow(1024, 4) * 8);
            Console.WriteLine($"{bits:f0}");
        }
    }
}
