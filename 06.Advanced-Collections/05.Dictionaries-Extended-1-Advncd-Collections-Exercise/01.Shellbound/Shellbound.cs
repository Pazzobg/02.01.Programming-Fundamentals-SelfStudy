namespace _01.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            var shellCollection = new Dictionary<string, HashSet<int>>();

            input = AccumulatingShellsCollection(input, shellCollection);

            PrintingOutput(shellCollection);
        }

        public static void PrintingOutput(Dictionary<string, HashSet<int>> shellCollection)
        {
            foreach (var area in shellCollection)
            {
                string areaName = area.Key;
                var shellsList = area.Value;

                int shellSum = shellsList.Sum();
                double giantShell = shellSum - (shellSum / shellsList.Count);

                Console.WriteLine($"{areaName} -> {string.Join(", ", shellsList)} ({giantShell})");
            }
        }

        public static string[] AccumulatingShellsCollection(string[] input, Dictionary<string, HashSet<int>> shellCollection)
        {
            while (input[0] != "Aggregate")
            {
                string area = input[0];
                int currentShellSize = int.Parse(input[1]);

                if (!shellCollection.ContainsKey(area))
                {
                    shellCollection[area] = new HashSet<int>();
                }

                shellCollection[area].Add(currentShellSize);

                input = Console.ReadLine().Split(' ');
            }

            return input;
        }
    }
}
