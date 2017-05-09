using System;

namespace _15.FastPrimeCheckerRefactor
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int endNummber = int.Parse(Console.ReadLine());

            for (int i = 2; i <= endNummber; i++)
            {
                bool prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }
        }
    }
}
