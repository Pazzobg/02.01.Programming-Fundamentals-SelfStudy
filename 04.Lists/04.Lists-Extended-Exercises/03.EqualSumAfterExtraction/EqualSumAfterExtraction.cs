namespace _03.EqualSumAfterExtraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                int currentNum = firstList[i];
                secondList.Remove(currentNum);

                if (secondList.Contains(currentNum)) i--;     // Repeats checking for the same number till
            }                                                 // the end of the list, as requested

            if (firstList.Sum() == secondList.Sum())
            {
                Console.WriteLine($"Yes. Sum: {firstList.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstList.Sum() - secondList.Sum())}");
            }
        }
    }
}
