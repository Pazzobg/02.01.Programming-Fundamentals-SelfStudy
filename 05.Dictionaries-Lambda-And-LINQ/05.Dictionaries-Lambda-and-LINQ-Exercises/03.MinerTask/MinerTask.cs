namespace _03.MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinerTask
    {
        public static void Main()
        {
            Dictionary<string, int> minersDict = new Dictionary<string, int>();
            int counter = 1;
            string lastResourceName = string.Empty;

            string input = Console.ReadLine();

            while (input != "stop")
            {
                if (counter % 2 == 1)
                {
                    if (!minersDict.ContainsKey(input))
                    {
                        minersDict[input] = 0;
                    }

                    lastResourceName = input;
                }
                else
                {
                    int quantity = int.Parse(input);
                    minersDict[lastResourceName] += quantity;
                }

                counter++;
                input = Console.ReadLine();
            }

            foreach (var kvp in minersDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
