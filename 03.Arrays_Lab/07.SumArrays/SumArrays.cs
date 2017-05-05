namespace _07.SumArrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            var firstNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int longerLength = Math.Max(firstNumbers.Length, secondNumbers.Length);
            int[] result = new int[longerLength];

            for (int i = 0; i < longerLength; i++)
            {
                result[i] = firstNumbers[i % firstNumbers.Length] + secondNumbers[i % secondNumbers.Length];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
