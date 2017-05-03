namespace _13.FactorialToThousand
{
    using System;
    using System.Numerics;

    public class Factorial
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

            Console.WriteLine(factorial);
        }
    }
}
