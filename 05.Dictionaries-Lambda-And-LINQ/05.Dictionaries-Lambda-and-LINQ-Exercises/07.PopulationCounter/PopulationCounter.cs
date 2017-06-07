namespace _07.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var countriesDict = new Dictionary<string, Dictionary<string, long>>();

            string[] input = Console.ReadLine().Split('|');

            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);

                if (!countriesDict.ContainsKey(country))
                {
                    countriesDict[country] = new Dictionary<string, long>();
                }

                if (!countriesDict[country].ContainsKey(city))
                {
                    countriesDict[country][city] = 0;
                }

                countriesDict[country][city] = population;

                input = Console.ReadLine().Split('|');
            }

            /* SHORTER VERSION - we work with the initial dictionary only. x => x.Value.Values.Sum() takes the sum
             * of all values in the nested dictionary, accessed by x.Value of the outer dict.*/

            foreach (var kvp in countriesDict.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{kvp.Key} (total population: {kvp.Value.Values.Sum()})");

                foreach (var townPair in countriesDict[kvp.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{townPair.Key}: {townPair.Value}");
                }
            }

            /* LONGER VERSION - Create second dictionary for countries with total population figures only
             * and in the final print-foreach we take KVPs from both dictionaries: 
             * 
             * 
            var countryByTotalPopulation = new Dictionary<string, long>();

            foreach (var country in countriesDict)  
            {
                string currentCountry = country.Key;

                countryByTotalPopulation[currentCountry] = 0;

                foreach (var kvp in countriesDict[currentCountry])
                {
                    countryByTotalPopulation[currentCountry] += kvp.Value;
                }
            }

            foreach (var kvp in countryByTotalPopulation.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key} (total population: {kvp.Value})");

                foreach (var townPair in countriesDict[kvp.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{townPair.Key}: {townPair.Value}");
                } 
            }*/
        }
    }
}
