namespace _02.OptimizedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            var accounts = new List<BankAccount>();

            string[] input = Console.ReadLine().Split('|');

            while (input[0] != "end")
            {
                string currentBank = input[0].Trim();
                string currentPerson = input[1].Trim();
                decimal currentBallance = decimal.Parse(input[2].Trim());

                var currentAccount = new BankAccount
                {
                    Bank = currentBank,
                    Name = currentPerson,
                    Ballance = currentBallance
                };

                accounts.Add(currentAccount);

                input = Console.ReadLine().Split('|');
            }

            foreach (var account in accounts
                .OrderByDescending(x => x.Ballance)
                .ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine($"{account.Name} -> {account.Ballance} ({account.Bank})");
            }
        }
    }
}
