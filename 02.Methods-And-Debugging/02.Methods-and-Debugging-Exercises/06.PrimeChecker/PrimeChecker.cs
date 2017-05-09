namespace _06.PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            bool result = IsPrime(n);

            Console.WriteLine(result);
        }

        public static bool IsPrime(long n)
        {
            bool prime = true;
            long divider = 2;
            double maxDivider = Math.Sqrt(n);
            long result = 1;

            if (n < 2)
            {
                prime = false;
            }
            else
            {
                while (prime && (divider <= maxDivider))
                {
                    result = n % divider;
                    if (result == 0)
                    {
                        prime = false;
                    }

                    divider++;
                }
            }

            return prime;
        }
    }
}
