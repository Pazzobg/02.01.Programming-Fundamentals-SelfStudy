namespace _05.DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;

    public class DecodeRadioFreqs
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            var outputList = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentString = input[i].ToString();
                var splitByDot = currentString.Split('.');
                int wholePart = int.Parse(splitByDot[0]);
                int decimalPart = int.Parse(splitByDot[1]);

                if (wholePart != 0)
                {
                    outputList.Insert(i, (char)wholePart);
                }

                if (decimalPart != 0)
                {
                    outputList.Insert(outputList.Count - 1 - i, (char)decimalPart);
                }
            }

            outputList.Reverse();
            Console.WriteLine(string.Join(string.Empty, outputList));
        }
    }
}
