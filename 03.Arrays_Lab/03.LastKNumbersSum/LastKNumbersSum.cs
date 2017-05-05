namespace _03.LastKNumbersSum
{
    using System;

    public class LastKNumbersSum
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            var numbers = new long[n];
            numbers[0] = 1;

            for (long current = 0; current < numbers.Length; current++)
            {
                var start = Math.Max(0, (current - k));
                var end = current - 1;
                long sum = 0;

                for (long i = start; i < n; i++)
                {
                    sum += numbers[i];
                }

                numbers[current] = sum;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
