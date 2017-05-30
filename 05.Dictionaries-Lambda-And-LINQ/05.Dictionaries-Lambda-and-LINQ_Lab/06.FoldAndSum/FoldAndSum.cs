namespace _06.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
			// Shorter solution (even two solutions)
			// var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            // int k = input.Count / 4;
            // 
            // var topLeft = input.Take(k).Reverse().ToList();
            // var topRight = input.Skip(3 * k).Take(k).Reverse().ToList();
            // var topRow = topLeft.Concat(topRight).ToList();
            // var bottomRow = input.Skip(k).Take(2 * k).ToList();
            // 
            // var result = topRow.Select((x, index) => x + bottomRow[index]); // .Select - Solution
            // 
            // //var result = topRow.Zip(bottomRow, (x, y) => (x + y));        // .Zip - Solution
            // 
            // Console.WriteLine(string.Join(" ", result));

			
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
