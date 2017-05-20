namespace _04.ArrayHistogram
{
    using System;
    using System.Collections.Generic;

    public class ArrayHistogram
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            var wordsList = new List<string>();
            var countsList = new List<int>();
            var percentageList = new List<double>();

            CountingWords(input, wordsList, countsList);

            SortBothNamesAndCounts(wordsList, countsList);

            CalculatePercentages(countsList, percentageList, input);

            for (int i = 0; i < countsList.Count; i++)
            {
                Console.WriteLine($"{wordsList[i]} -> {countsList[i]} times ({percentageList[i]:f2}%)");
            }
        }

        public static void CountingWords(string[] input, List<string> wordsList, List<int> countsList)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int count = 0;

                if (!wordsList.Contains(input[i]))
                {
                    wordsList.Add(input[i]);

                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[i] == input[j])
                        {
                            count++;
                        }
                    }

                    countsList.Add(count);
                }
            }
        }

        public static void SortBothNamesAndCounts(List<string> wordsList, List<int> countsList)
        {
            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < countsList.Count - 1; i++)
                {
                    if (countsList[i + 1] > countsList[i])
                    {
                        int tempCount = countsList[i];
                        string tempWord = wordsList[i];

                        countsList[i] = countsList[i + 1];
                        wordsList[i] = wordsList[i + 1];

                        countsList[i + 1] = tempCount;
                        wordsList[i + 1] = tempWord;

                        swapped = true;
                    }
                }
            } while (swapped);
        }

        public static void CalculatePercentages(List<int> countsList, List<double> percentageList, string[] input)
        {
            for (int i = 0; i < countsList.Count; i++)
            {
                percentageList.Add(((double)countsList[i] / input.Length) * 100);
            }
        }
    }
}
