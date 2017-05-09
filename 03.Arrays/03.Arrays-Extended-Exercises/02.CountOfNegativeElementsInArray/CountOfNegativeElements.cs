namespace _02.CountOfNegativeElementsInArray
{
    using System;

    public class CountOfNegativeElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            int counterNegatives = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] < 0)
                {
                    counterNegatives++;
                }
            }

            Console.WriteLine(counterNegatives);
        }
    }
}
