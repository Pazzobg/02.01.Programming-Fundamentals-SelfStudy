namespace _02.DefaultValue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValue
    {
        public static void Main()
        {
            var itemsDict = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                string inputKey = input[0];
                string inputValue = input[1];

                itemsDict[inputKey] = inputValue;

                input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string defaultValue = Console.ReadLine();

            var nullValuesDict = new Dictionary<string, string>();
            var fullValuesDict = new Dictionary<string, string>();

            nullValuesDict = itemsDict
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            fullValuesDict = itemsDict
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in fullValuesDict)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }

            foreach (var kvp  in nullValuesDict)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
        }
    }
}
