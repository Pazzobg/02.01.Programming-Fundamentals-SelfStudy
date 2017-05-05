namespace _01.SumArrayElements
{
    using System;

    public class SumArrayElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            var numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
