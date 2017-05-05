namespace _06.OddNumbersAtOddPositions
{
    using System;
    using System.Linq;

    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {inputArr[i]}");
                }
            }
        }
    }
}
