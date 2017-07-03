namespace _01.SerializeString
{
    using System;
    using System.Collections.Generic;

    public class SerializeString
    {
        public static void Main()
        {
            var series = new Dictionary<char, List<int>>();

            char[] chars = Console.ReadLine().ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char currentChar = chars[i];

                if (!series.ContainsKey(currentChar))
                {
                    series[currentChar] = new List<int>();

                    for (int j = 0; j < chars.Length; j++)
                    {
                        if (currentChar == chars[j])
                        {
                            series[currentChar].Add(j);
                        }
                    }
                }
            }

            foreach (var kvp in series)
            {
                Console.Write($"{kvp.Key}:");
                Console.WriteLine(string.Join("/", kvp.Value));
            }
        }
    }
}
