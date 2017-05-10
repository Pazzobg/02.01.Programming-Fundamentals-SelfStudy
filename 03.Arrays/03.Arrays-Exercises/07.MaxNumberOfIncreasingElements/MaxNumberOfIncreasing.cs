namespace _07.MaxNumberOfIncreasingElements
{
    using System;
    using System.Linq;

    public class MaxNumberOfIncreasing
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int bestLength = 1;
            int startIncrease = 0;

            for (int i = 1; i < numbers.Length; i++)    // Check if next element is greater
            {
                if (numbers[i] > numbers[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > bestLength)
                {
                    bestLength = counter;
                    startIncrease = i - bestLength + 1;     // Keeping the array index of the starting element
                }                                           // of the increasing row
            }

            for (int i = startIncrease; i < startIncrease + bestLength; i++)    // Printing the needed elements
            {                                                                   // from the nums-Array using the 
                Console.Write($"{numbers[i]} ");                                // starting index and the count
            }                                                                   // of the increasing elements

            Console.WriteLine();
        }
    }
}
