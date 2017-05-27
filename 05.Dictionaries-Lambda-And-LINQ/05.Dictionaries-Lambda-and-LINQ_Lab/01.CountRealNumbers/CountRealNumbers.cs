namespace _01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var counts = new SortedDictionary<double, int>();

            foreach (var number in inputList)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }

                counts[number]++;
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
