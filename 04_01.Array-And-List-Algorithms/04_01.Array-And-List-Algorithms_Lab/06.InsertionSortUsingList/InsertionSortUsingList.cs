namespace _06.InsertionSortUsingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InsertionSortUsingList
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool inserted = false;
                int currentNum = numbers[i];

                for (int j = 0; j < result.Count; j++)
                {
                    int currentListElement = result[j];

                    if (currentNum <= currentListElement)
                    {
                        result.Insert(Math.Max(0, j), currentNum);
                        inserted = true;
                        break;
                    }
                }
                
                if (!inserted)
                {
                    result.Add(currentNum);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
