namespace _06.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main()
        {
            var usersDict = new SortedDictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split(' ');
            while (input[0] != "end")
            {
                string ipInfo = input[0];
                string messageInfo = input[1];
                string userInfo = input[2];

                string nameParsed = userInfo.Split('=')[1];
                string ipParsed = ipInfo.Split('=')[1];

                if (!usersDict.ContainsKey(nameParsed))
                {
                    usersDict[nameParsed] = new Dictionary<string, int>();
                }

                if (!usersDict[nameParsed].ContainsKey(ipParsed))
                {
                    usersDict[nameParsed][ipParsed] = 0;
                }

                usersDict[nameParsed][ipParsed]++;

                input = Console.ReadLine().Split(' ');
            }

            foreach (var userInfo in usersDict)
            {
                string user = userInfo.Key;
                var ipInfoAndCount = userInfo.Value;

                Console.WriteLine($"{user}:");

                foreach (var kvp in ipInfoAndCount)
                {
                    string ip = kvp.Key;
                    int messagesFromThisIp = kvp.Value;

                    if (kvp.Key != ipInfoAndCount.Keys.Last())      // Prints commas after each one but the last, 
                    {                                               // so that it's poss to finish the line with a dot.
                        Console.Write($"{ip} => {messagesFromThisIp}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ip} => {messagesFromThisIp}.");
                    }
                }
            }

            //foreach (var usersInfo in usersDict)          // Another way to print the line with
            //{                                             // with commas and a dot at the end. 
            //    string user = usersInfo.Key;
            //    var ipInfoAndCount = usersInfo.Value;

            //    Console.WriteLine($"{user}: ");

            //    foreach (var kvp in ipInfoAndCount)
            //    {
            //        if (!kvp.Equals(ipInfoAndCount.Last()))
            //        {
            //            Console.Write($"{kvp.Key} => {kvp.Value}, ");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{kvp.Key} => {kvp.Value}.");
            //        }
            //    }
            //}
        }
    }
}
