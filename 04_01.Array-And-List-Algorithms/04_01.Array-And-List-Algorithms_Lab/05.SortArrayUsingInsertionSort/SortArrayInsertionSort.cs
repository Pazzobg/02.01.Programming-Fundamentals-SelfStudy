namespace _05.SortArrayUsingInsertionSort
{
    using System;
    using System.Linq;

    public class SortArrayInsertionSort
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 1; i < numbers.Length; i++)
            {
                int currentNum = i;

                while (currentNum > 0)
                {
                    if (numbers[currentNum] < numbers[currentNum - 1])
                    {
                        int temp = numbers[currentNum - 1];
                        numbers[currentNum - 1] = numbers[currentNum];
                        numbers[currentNum] = temp;
                    }

                    currentNum--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
