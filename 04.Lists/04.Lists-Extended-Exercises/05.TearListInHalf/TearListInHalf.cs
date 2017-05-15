namespace _05.TearListInHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TearListInHalf
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var bottomList = new List<int>();
            var topList = new List<int>();
            var resultList = new List<int>();
            int middle = input.Count / 2;

            var brokenDigitsList = new List<int>();

            for (int i = 0; i < middle; i++)
            {
                bottomList.Add(input[i]);
            }

            for (int j = middle; j < input.Count; j++)
            {
                topList.Add(input[j]);
            }

            for (int i = 0; i < topList.Count; i++)
            {
                brokenDigitsList.Add(topList[i] / 10);
                brokenDigitsList.Add(topList[i] % 10);
            }

            for (int i = 0; i < bottomList.Count; i++)
            {
                resultList.Add(brokenDigitsList[i * 2]);
                resultList.Add(bottomList[i]);
                resultList.Add(brokenDigitsList[(i * 2) + 1]);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
