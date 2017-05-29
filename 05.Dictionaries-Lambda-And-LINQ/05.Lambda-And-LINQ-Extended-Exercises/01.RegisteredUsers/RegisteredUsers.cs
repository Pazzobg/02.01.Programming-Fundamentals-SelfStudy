namespace _01.RegisteredUsers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class RegisteredUsers
    {
        public static void Main()
        {
            var usersDict = new Dictionary<string, DateTime>();
            string[] input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                string userName = input[0];
                DateTime regDate = DateTime.ParseExact(input[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!usersDict.ContainsKey(userName))
                {
                    usersDict[userName] = regDate;
                }

                input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var outputDict = usersDict
                .Reverse()
                .OrderBy(d => d.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in outputDict)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
