namespace _04.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNums
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string reversed = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            var outputList = reversed.Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            foreach (var item in outputList)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
