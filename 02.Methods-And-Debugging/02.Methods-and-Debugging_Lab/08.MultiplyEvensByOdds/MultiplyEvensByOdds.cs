namespace _08.MultiplyEvensByOdds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleEvensByOdds(input);

            Console.WriteLine(result);
        }

        public static int GetMultipleEvensByOdds(int n)
        {
            int evenSum = SumEvens(n);
            int oddSum = SumOdds(n);
            return evenSum * oddSum;
        }

        public static int SumEvens(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastdigit = 0;
                lastdigit = n % 10;
                n /= 10;

                if (lastdigit % 2 == 0)
                {
                    sum += lastdigit;
                }
            }

            return sum;
        }

        public static int SumOdds(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastdigit = 0;
                lastdigit = n % 10;
                n /= 10;

                if (lastdigit % 2 != 0)
                {
                    sum += lastdigit;
                }
            }

            return sum;
        }
    }
}
