namespace _04.CountOccurancesOfLargerNumbersInArray
{
    using System;
    using System.Linq;

    public class CountOccurancesOfLargerNumber
    {
        public static void Main()
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double specialK = double.Parse(Console.ReadLine());

            int foundCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > specialK)
                {
                    foundCounter++;
                }
            }

            Console.WriteLine(foundCounter);
        }
    }
}
