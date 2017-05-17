namespace _04.SumReversedNumbers_02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNums02
    {
        public static void Main()
        {
            string[] inputNums = Console.ReadLine().Split();
            string currentNumber = string.Empty;
            string reversedNumber = string.Empty;
            int parsedNum = 0;
            int sum = 0;

            for (int i = 0; i < inputNums.Length; i++)
            {
                currentNumber = inputNums[i];
                reversedNumber = string.Join(string.Empty, currentNumber.Reverse());
                parsedNum = int.Parse(reversedNumber);
                sum += parsedNum;
            }

            Console.WriteLine(sum);
        }
    }
}
