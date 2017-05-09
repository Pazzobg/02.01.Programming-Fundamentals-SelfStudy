namespace _00.Practice
{
    using System;

    public class Practice
    {
        public static void Main()
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());

            CalcPrime(start, end);
        }

        public static void CalcPrime(long start, long end)
        {

            bool flag = true;

            for (long i = start; i <= end; i++)
            {

                bool prime = true;
                long divider = 2;
                double maxDivider = Math.Sqrt(i);
                long result = 1;

                if (i < 2)
                {
                    prime = false;
                }
                else
                {
                    while (prime && (divider <= maxDivider))
                    {
                        result = i % divider;
                        if (result == 0)
                        {
                            prime = false;
                        }

                        divider++;
                    }

                    if (prime && flag)
                    {
                        Console.Write(i);
                        flag = false;
                    }
                    else if (prime)
                    {
                        Console.Write($", {i}");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}