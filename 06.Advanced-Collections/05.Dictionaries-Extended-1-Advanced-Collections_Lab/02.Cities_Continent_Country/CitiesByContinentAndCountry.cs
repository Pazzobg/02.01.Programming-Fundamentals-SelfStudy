namespace _02.Cities_Continent_Country
{
    using System;
    using System.Collections.Generic;

    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string continentName = input[0];
                string countryName = input[1];
                string cityName = input[2];

                if (!continents.ContainsKey(continentName))
                {
                    continents[continentName] = new Dictionary<string, List<string>>();
                }

                if (!continents[continentName].ContainsKey(countryName))
                {
                    continents[continentName][countryName] = new List<string>();
                }

                continents[continentName][countryName].Add(cityName);
            }

            foreach (var continent in continents)
            {
                var continentName = continent.Key;
                var countries = continent.Value;

                Console.WriteLine($"{continentName}:");

                foreach (var country in countries)
                {
                    string currentCountry = country.Key;
                    List<string> cities = country.Value;

                    Console.WriteLine($"  {currentCountry} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
