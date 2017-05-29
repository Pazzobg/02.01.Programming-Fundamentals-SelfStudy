namespace _03.FlattenDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlattenDictionary
    {
        public static void Main()
        {
            var generalDict = new Dictionary<string, Dictionary<string, string>>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "end")
            {
                if (input[0] != "flatten")
                {
                    string genDictKey = input[0];
                    string innerDictKey = input[1];
                    string innerDictValue = input[2];

                    if (!generalDict.ContainsKey(genDictKey))
                    {
                        generalDict[genDictKey] = new Dictionary<string, string>();
                    }

                    if (!generalDict[genDictKey].ContainsKey(innerDictValue))
                    {
                        generalDict[genDictKey][innerDictKey] = string.Empty;
                    }

                    generalDict[genDictKey][innerDictKey] = innerDictValue;
                }
                else
                {
                    string keyToFlatten = input[1];

                    generalDict[keyToFlatten] = generalDict[keyToFlatten]
                    .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                input = Console.ReadLine().Split();
            }

            var orderedDict = generalDict
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderedDict)
            {
                Console.WriteLine(kvp.Key);

                var orderedInnerDict = kvp.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenedElements = kvp.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);
                int counter = 1;

                foreach (var kvPair in orderedInnerDict)
                {
                    Console.WriteLine($"{counter}. {kvPair.Key} - {kvPair.Value}");
                    counter++;
                }

                foreach (var kvPair in flattenedElements)
                {
                    Console.WriteLine($"{counter}. {kvPair.Key}");
                    counter++;
                }
            }
        }
    }
}
