namespace _07.PrimesInGivenRange_ListSolution
{
    using System;
    using System.Collections.Generic;

    public class PrimesInRangeList
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            var result = string.Join(", ", CheckPrimesInRange(start, end));

            Console.WriteLine(result);
        }

        public static List<int> CheckPrimesInRange(int start, int end)
        {
            List<int> primeNumbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                bool prime = true;
                int divider = 2;
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

                    if (prime)
                    {
                        primeNumbers.Add(i);
                    }
                }
            }

            return primeNumbers;
        }
    }
}
