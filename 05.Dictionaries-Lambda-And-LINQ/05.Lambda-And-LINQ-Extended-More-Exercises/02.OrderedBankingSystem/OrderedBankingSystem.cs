namespace _02.OrderedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderedBankingSystem
    {
        public static void Main()
        {
            var bankDict = new Dictionary<string, Dictionary<string, decimal>>();

            string[] input = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                string bank = input[0];
                string accountHolder = input[1];
                decimal balance = decimal.Parse(input[2]);

                if (!bankDict.ContainsKey(bank))
                {
                    bankDict[bank] = new Dictionary<string, decimal>();
                }

                if (!bankDict[bank].ContainsKey(accountHolder))
                {
                    bankDict[bank][accountHolder] = 0;
                }

                bankDict[bank][accountHolder] += balance;

                input = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }
            
            var orderedBanks = bankDict
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenByDescending(x => x.Value.Max(y => y.Value))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderedBanks)
            {
                string bank = kvp.Key;
                var accounts = kvp.Value;

                var orderedAccounts = accounts
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var account in orderedAccounts)
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({bank})");
                }
            }
        }
    }
}
