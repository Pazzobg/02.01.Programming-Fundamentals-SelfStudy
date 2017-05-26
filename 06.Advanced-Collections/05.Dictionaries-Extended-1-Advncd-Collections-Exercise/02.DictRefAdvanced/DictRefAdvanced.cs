namespace _02.DictRefAdvanced
{
    using System;
    using System.Collections.Generic;

    public class DictRefAdvanced
    {
        public static void Main()
        {
            var collection = new Dictionary<string, List<int>>();

            string[] input = Console.ReadLine().Split(new[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                string name = input[0];

                int currentValue = 0;
                bool itSaNumber = int.TryParse(input[1], out currentValue);

                if (itSaNumber)
                {
                    if (!collection.ContainsKey(name))
                    {
                        collection[name] = new List<int>();
                    }

                    for (int i = 1; i <= input.Length - 1; i++)
                    {
                        collection[name].Add(int.Parse(input[i]));
                    }
                }
                else
                {
                    string otherKey = input[1];

                    if (!collection.ContainsKey(otherKey))
                    {
                        input = Console.ReadLine().Split(new[] { ' ', ',', '-', '>' },
                        StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    else if (!collection.ContainsKey(name))
                    {
                        collection[name] = new List<int>();
                    }

                    collection[name].AddRange(collection[otherKey]);    //vytre v if-a????
                }

                input = Console.ReadLine().Split(new[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvpair in collection)
            {
                Console.WriteLine($"{kvpair.Key} === {string.Join(", ", kvpair.Value)}");
            }
        }
    }
}
