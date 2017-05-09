namespace _02.MaxMethod
{
    using System;

    public class MaxMethod
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maxAorB = GetMax(num1, num2);
            int maxResult = UltimateMax(maxAorB, num3);

            Console.WriteLine(maxResult);
        }

        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static int UltimateMax(int a, int b)
        {
            return GetMax(a, b);
        }
    }
}
