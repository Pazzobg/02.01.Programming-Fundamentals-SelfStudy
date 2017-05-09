using System;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool special = false;
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    special = true;
                }
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
