namespace _04.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CottageScraper
    {
        public static void Main()
        {
            var logsDict = new Dictionary<string, List<double>>();
            int counter = 0;
            string[] input = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "chop")
            {
                string treeType = input[0];
                double length = double.Parse(input[1]);

                if (!logsDict.ContainsKey(treeType))
                {
                    logsDict[treeType] = new List<double>();
                }

                logsDict[treeType].Add(length);
                counter++;

                input = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

            string chosenTree = Console.ReadLine();
            double cottageHeigth = double.Parse(Console.ReadLine());

            double pricePerMeter = Math.Round(logsDict.Values.Sum(d => d.Sum()) / counter, 2);

            var usedLogs = logsDict[chosenTree]
                .Where(x => x >= cottageHeigth)
                .Sum();
            double usedLogsPrice = Math.Round(usedLogs * pricePerMeter, 2);

            var unusedLogs = logsDict.Values.Sum(x => x.Sum()) - usedLogs;
            double unusedLogsPrice = Math.Round((unusedLogs * pricePerMeter) * 0.25, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${ usedLogsPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${usedLogsPrice + unusedLogsPrice:f2}");
        }
    }
}
