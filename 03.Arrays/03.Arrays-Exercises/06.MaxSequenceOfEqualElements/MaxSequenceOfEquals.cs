namespace _06.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEquals
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int bestLength = 1;
            int specialNum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
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
                    specialNum = numbers[i];
                }
            }

            int[] output = new int[bestLength];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = specialNum;
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
