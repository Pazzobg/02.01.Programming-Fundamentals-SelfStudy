namespace _06.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = numbers.Length / 4;

            var upperLeftRow = numbers
                .Take(n)
                .Reverse()
                .ToList();

            var upperRightRow = numbers
                .Skip(3 * n)
                .Take(n)
                .Reverse()
                .ToList();

            var lowerRow = numbers
                .Skip(n)
                .Take(2 * n)
                .ToList();

            var upperRow = upperLeftRow
                .Concat(upperRightRow)
                .ToList();

            var result = new List<int>();

            for (int i = 0; i < 2*n; i++)
            {
                result.Add(upperRow[i] + lowerRow[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
