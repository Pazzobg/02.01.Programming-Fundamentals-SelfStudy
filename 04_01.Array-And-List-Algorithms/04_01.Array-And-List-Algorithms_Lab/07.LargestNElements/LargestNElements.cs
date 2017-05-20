namespace _07.LargestNElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestNElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            var result = new List<int>();

            var sortedNumbers = ManualSortList(numbers);
            var reversedNumbers = ManualReverseList(sortedNumbers);

            for (int i = 0; i < n; i++)
            {
                result.Add(reversedNumbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }

        public static List<int> ManualReverseList(List<int> sortedNumbers)
        {
            var reversed = new List<int>();
            for (int i = sortedNumbers.Count - 1; i >= 0; i--)
            {
                reversed.Add(sortedNumbers[i]);
            }

            return reversed;
        }

        public static List<int> ManualSortList(List<int> numbers)
        {
            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);

            return numbers;
        }
    }
}
