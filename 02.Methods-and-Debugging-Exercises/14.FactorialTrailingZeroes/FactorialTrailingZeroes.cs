namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            int end = int.Parse(Console.ReadLine());

            CalculateFactorial(end);
        }

        public static void CalculateFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(CalculateTrailingZeroes(factorial));
        }

        public static int CalculateTrailingZeroes(BigInteger bigNum)
        {
            int zeroesCounter = 0;

            while (bigNum % 10 == 0)
            {
                zeroesCounter++;
                bigNum /= 10;
            }

            return zeroesCounter;
        }
    }
}
