namespace _05.CountOfOddNumbersInArray
{
    using System;
    using System.Linq;

    public class CountOfOddNumbersInArray
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counterOdds = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 != 0)
                {
                    counterOdds++;
                }
            }

            Console.WriteLine(counterOdds);
        }
    }
}
