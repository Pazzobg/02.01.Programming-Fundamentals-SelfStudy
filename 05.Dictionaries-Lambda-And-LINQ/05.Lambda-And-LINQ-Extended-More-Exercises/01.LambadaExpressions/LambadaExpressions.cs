namespace _01.LambadaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LambadaExpressions
    {
        public static void Main()
        {
            var expressionsCollection = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(new[] { ' ', '=', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "lambada")
            {
                string selector = input[0];

                if (selector != "dance")
                {
                    string objectAndProperty = input[1];
                    expressionsCollection[selector] = objectAndProperty;
                }
                else
                {
                    expressionsCollection = expressionsCollection
                        .ToDictionary(x => x.Key, x => $"{x.Key}.{x.Value}");
                }

                input = Console.ReadLine().Split(new[] { ' ', '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in expressionsCollection)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
