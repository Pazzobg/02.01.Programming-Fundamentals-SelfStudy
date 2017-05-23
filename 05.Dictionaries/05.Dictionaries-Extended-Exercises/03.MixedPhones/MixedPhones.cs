namespace _03.MixedPhones
{
    using System;
    using System.Collections.Generic;

    public class MixedPhones
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            var resultDict = new SortedDictionary<string, long>();

            while (input[0] != "Over")
            {
                long currentValue = 0;
                string leftStringValue = input[0];
                string rightStringValue = input[1];
                bool parsedSuccessfully = long.TryParse(rightStringValue, out currentValue);

                if (parsedSuccessfully)
                {
                    if (!resultDict.ContainsKey(leftStringValue)) 
                    {
                        resultDict.Add(leftStringValue, 0);
                    }

                    resultDict[leftStringValue] = currentValue;
                }
                else
                {
                    currentValue = long.Parse(leftStringValue);

                    if (!resultDict.ContainsKey(rightStringValue))
                    {
                        resultDict.Add(rightStringValue, 0);
                    }

                    resultDict[rightStringValue] = currentValue;
                }

                input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in resultDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
