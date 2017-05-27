namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ');

            var wordsCount = new Dictionary<string, int>();

            var result = new List<string>();

            foreach (var word in words)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount[word] = 0;
                }

                wordsCount[word]++;
            }

            foreach (var item in wordsCount)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
