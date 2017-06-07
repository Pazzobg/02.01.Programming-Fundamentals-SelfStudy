namespace _10.SrybskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SrybskoUnleashed
    {
        public static void Main()
        {
            var venuesDict = new Dictionary<string, Dictionary<string, long>>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "End")
            {
                bool foundAt = false;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].Contains("@"))
                    {
                        foundAt = true;
                        break;
                    }
                }

                if (!foundAt)
                {
                    input = Console.ReadLine().Split(' ');
                    continue;
                }

                long outValue = 0;
                bool lastIsNumber = long.TryParse(input[input.Length - 1], out outValue);
                bool forelastIsNumber = long.TryParse(input[input.Length - 2], out outValue);
                if (!lastIsNumber || !forelastIsNumber)
                {
                    input = Console.ReadLine().Split(' ');
                    continue;
                }

                if (input.Length >= 4) // Strah loze pazi :D
                {
                    string artist = GetArtist(input);
                    string venue = GetVenue(input);
                    string ticketsSold = input[input.Length - 1];
                    string ticketPrice = input[input.Length - 2];
                    long totalTicketRevenue = long.Parse(ticketPrice) * long.Parse(ticketsSold);

                    if (!venuesDict.ContainsKey(venue))
                    {
                        venuesDict[venue] = new Dictionary<string, long>();
                    }

                    if (!venuesDict[venue].ContainsKey(artist))
                    {
                        venuesDict[venue][artist] = 0;
                    }

                    venuesDict[venue][artist] += totalTicketRevenue;

                    input = Console.ReadLine().Split(' ');
                }
                else
                {
                    input = Console.ReadLine().Split(' ');
                }
            }

            foreach (var kvp in venuesDict)
            {
                string venue = kvp.Key;
                var artistsAndProfit = kvp.Value;

                Console.WriteLine(venue);

                foreach (var kvpInner in artistsAndProfit.OrderByDescending(x => x.Value))
                {
                    string artist = kvpInner.Key;
                    long profit = kvpInner.Value;

                    Console.WriteLine($"#  {artist} -> {profit}");
                }
            }
        }

        public static string GetArtist(string[] input)
        {
            string name = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (!input[i].Contains("@"))
                {
                    name += input[i];
                    name += " ";
                }
                else
                {
                    break;
                }
            }

            return name.TrimEnd();
        }

        public static string GetVenue(string[] input)
        {
            string venueName = string.Empty;
            bool venueStarted = false;

            for (int i = 0; i < input.Length - 2; i++)
            {
                if (input[i].Contains("@") && !venueStarted)
                {
                    venueName += input[i];
                    venueName += " ";
                    venueStarted = true;
                }
                else if (venueStarted)
                {
                    venueName += input[i];
                    venueName += " ";
                }
            }

            return venueName.Trim(new[] { '@', ' ' });
        }
    }
}