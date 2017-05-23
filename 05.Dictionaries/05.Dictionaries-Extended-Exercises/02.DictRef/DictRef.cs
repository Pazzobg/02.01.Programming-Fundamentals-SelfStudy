namespace _02.DictRef
{
    using System;
    using System.Collections.Generic;

    public class DictRef
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var resultDict = new Dictionary<string, int>();

            while (input[0] != "end")
            {
                int currentValue = 0;
                string leftStringValue = input[0];
                string rightStringValue = input[1];
                bool successfullyParsed = int.TryParse(rightStringValue, out currentValue);

                if (successfullyParsed)
                {
                    if (!resultDict.ContainsKey(leftStringValue))
                    {
                        resultDict.Add(leftStringValue, 0);
                    }

                    resultDict[leftStringValue] = currentValue;
                }
                else
                {
                    if (resultDict.ContainsKey(rightStringValue))
                    {
                        resultDict[leftStringValue] = resultDict[rightStringValue];
                    }
                }

                input = Console.ReadLine().Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in resultDict)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
