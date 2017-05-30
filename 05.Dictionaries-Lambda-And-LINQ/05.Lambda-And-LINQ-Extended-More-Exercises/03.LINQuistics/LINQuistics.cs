namespace _03.LINQuistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LINQuistics
    {
        public static void Main()
        {
            var collections = new Dictionary<string, HashSet<string>>();

            string[] input = Console.ReadLine().Split("().".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "exit")
            {
                if (input.Length > 1)
                {
                    if (!collections.ContainsKey(input[0]))
                    {
                        collections[input[0]] = new HashSet<string>();
                    }

                    for (int i = 1; i < input.Length; i++)
                    {
                        collections[input[0]].Add(input[i]);
                    }
                }
                else
                {
                    int num = 0;
                    bool parsedSuccessfully = int.TryParse(input[0], out num);

                    if (!parsedSuccessfully)
                    {
                        string chosenCollection = input[0];
                        if (collections.ContainsKey(chosenCollection))
                        {
                            collections[chosenCollection]
                                .OrderByDescending(x => x.Length)
                                .ThenByDescending(x => x.Distinct().Count())
                                .ToList()
                                .ForEach(x => Console.WriteLine($"* {x}"));
                        }
                    }
                    else
                    {
                        collections.Values
                            .OrderByDescending(x => x.Count)
                            .Take(1)
                            .ToList()
                            .ForEach(x => Console.WriteLine($"* {string.Join("\n* ", x.OrderBy(y => y.Length).Take(num))}"));
                    }
                }

                input = Console.ReadLine().Split("().".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

            string[] filters = Console.ReadLine().Split(' ');
            string filterMethod = filters[0];
            string filterSelection = filters[1];

            var wantedCollection = collections
                .OrderByDescending(x => x.Value.Count)
                .ThenByDescending(x => x.Value.Min(y => y.Length));

            if (filterSelection == "collection")
            {
                foreach (var item in wantedCollection.Where(x => x.Value.Contains(filterMethod)))
                {
                    Console.WriteLine($"{item.Key}");
                }
            }
            else if (filterSelection == "all")
            {
                foreach (var item in wantedCollection.Where(x => x.Value.Contains(filterMethod)))
                {
                    Console.WriteLine($"{item.Key}");
                    foreach (var method in item.Value.OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($"* {method}");
                    }
                }
            }
        }
    }
}
