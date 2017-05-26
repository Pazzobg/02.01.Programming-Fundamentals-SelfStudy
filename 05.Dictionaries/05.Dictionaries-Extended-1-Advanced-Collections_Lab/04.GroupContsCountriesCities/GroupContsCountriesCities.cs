namespace _04.GroupContsCountriesCities
{
    using System;
    using System.Collections.Generic;

    public class GroupContsCountriesCities
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var continents = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continentName = input[0];
                string countryName = input[1];
                string cityName = input[2];

                if (!continents.ContainsKey(continentName))
                {
                    continents[continentName] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!continents[continentName].ContainsKey(countryName))
                {
                    continents[continentName][countryName] = new SortedSet<string>();
                }

                continents[continentName][countryName].Add(cityName);
            }

            foreach (var continent in continents)
            {
                string continentName = continent.Key;
                var countries = continent.Value;

                Console.WriteLine($"{continentName}: ");

                foreach (var kvp in countries)
                {
                    string countryName = kvp.Key;
                    var cities = kvp.Value;

                    Console.WriteLine($"  {countryName} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
