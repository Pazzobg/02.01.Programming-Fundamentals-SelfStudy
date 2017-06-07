namespace _08.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            var usersDict = new SortedDictionary<string, SortedDictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string ipAddress = input[0];
                string userName = input[1];
                int duration = int.Parse(input[2]);

                if (!usersDict.ContainsKey(userName))
                {
                    usersDict[userName] = new SortedDictionary<string, int>();
                }

                if (!usersDict[userName].ContainsKey(ipAddress))
                {
                    usersDict[userName][ipAddress] = 0;
                }

                usersDict[userName][ipAddress] += duration;
            }

            foreach (var user in usersDict)
            {
                string userName = user.Key;
                var durationAndIpInfo = user.Value;

                int totalDuration = durationAndIpInfo.Values.Sum();

                Console.WriteLine($"{userName}: {totalDuration} [{string.Join(", ", durationAndIpInfo.Keys)}]");
            }
        }
    }
}
