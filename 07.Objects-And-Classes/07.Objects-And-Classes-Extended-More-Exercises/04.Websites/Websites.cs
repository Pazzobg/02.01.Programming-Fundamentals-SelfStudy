namespace _04.Websites
{
    using System;
    using System.Collections.Generic;

    public class Websites
    {
        public static void Main()
        {
            var sites = new List<Website>();

            string[] input = Console.ReadLine().Split('|');

            while (input[0] != "end")
            {
                string currentHost = input[0].Trim();
                string currentDomain = input[1].Trim();

                var site = new Website
                {
                    Host = currentHost,
                    Domain = currentDomain,
                    Queries = new List<string>()
                };

                if (input.Length > 2)
                {
                    string[] currentQueries = input[2].Trim().Split(',');

                    site.Queries.AddRange(currentQueries);
                }

                sites.Add(site);

                input = Console.ReadLine().Split('|');
            }

            foreach (var site in sites)
            {
                if (site.Queries.Count > 0)
                {
                    Console.WriteLine($"https://www.{site.Host}.{site.Domain}/query" +
                        $"?=[{string.Join("]&[", site.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{site.Host}.{site.Domain}");
                }
            }
        }
    }
}