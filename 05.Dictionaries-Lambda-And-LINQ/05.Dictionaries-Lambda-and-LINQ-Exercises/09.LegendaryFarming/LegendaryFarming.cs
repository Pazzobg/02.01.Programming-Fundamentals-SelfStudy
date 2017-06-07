namespace _09.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            var legendaryItems = new Dictionary<string, string>
            {
                { "Shadowmourne", "shards" },
                { "Valanyr", "fragments" },
                { "Dragonwrath", "motes" }
            };

            var valuableItems = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 }
            };

            var junkItems = new SortedDictionary<string, int>();

            string winner = string.Empty;
            bool weHaveAWinner = false;

            while (!weHaveAWinner)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ');

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string item = input[i + 1];

                    if (item == "shards" || item == "fragments" || item == "motes")
                    {
                        valuableItems[item] += quantity;

                        if (valuableItems[item] >= 250)
                        {
                            winner = item;
                            valuableItems[item] -= 250;
                            weHaveAWinner = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(item))
                        {
                            junkItems[item] = 0;
                        }

                        junkItems[item] += quantity;
                    }
                }
            }

            foreach (var kvp in legendaryItems)
            {
                if (kvp.Value == winner) Console.WriteLine($"{kvp.Key} obtained!");
            }

            foreach (var kvp in valuableItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {                                                   // Order dictionary by descending order of materials 
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");   // and if two materials have the same amount -> 
            }                                                   // then order alphabetically

            foreach (var kvp in junkItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}