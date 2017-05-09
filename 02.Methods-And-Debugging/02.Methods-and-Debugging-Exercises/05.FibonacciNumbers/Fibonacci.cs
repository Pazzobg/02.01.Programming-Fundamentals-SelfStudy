namespace _05.FibonacciNumbers
{
    using System;

    public class Fibonacci
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int fibonacci = CalculateFibonacci(n);

            Console.WriteLine(fibonacci);
        }

        public static int CalculateFibonacci(int n)
        {
            int sum = 1;
            int lastNumber = 0;
            int previous = 1;

            for (int i = 0; i < n; i++)
            {
                sum = lastNumber + previous;

                lastNumber = previous;
                previous = sum;
            }

            return sum;
        }
    }
}
