namespace _05.UserLogins
{
    using System;
    using System.Collections.Generic;

    public class UserLogins
    {
        public static void Main()
        {
            var namesPasswords = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            int badLoginAttempts = 0;

            while (input[0] != "login")         // collecting database
            {
                string username = input[0];
                string password = input[1];

                if (!namesPasswords.ContainsKey(username))
                {
                    namesPasswords.Add(username, string.Empty);
                }

                namesPasswords[username] = password;

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")           // logging in
            {
                string username = input[0];
                string password = input[1];
                bool allDataCorrect = namesPasswords.ContainsKey(username) && namesPasswords[username] == password;

                if (allDataCorrect)
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{username}: login failed");
                    badLoginAttempts++;
                }

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"unsuccessful login attempts: {badLoginAttempts}"); //print bad login attempt summary
        }
    }
}
