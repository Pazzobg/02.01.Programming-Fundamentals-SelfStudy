namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            var emailsDict = new Dictionary<string, string>();
            int counter = 1;
            string input = Console.ReadLine();
            string currentUser = string.Empty;

            while (input != "stop")
            {
                if (counter % 2 != 0)
                {
                    emailsDict[input] = string.Empty;
                    currentUser = input;
                }
                else
                {
                    string[] separatedInput = input.Split('.');
                    string domain = separatedInput[1];
                    if (domain != "us" && domain != "uk" && domain != "US" && domain != "UK")
                    {
                        emailsDict[currentUser] = input;
                    }
                    else
                    {
                        emailsDict.Remove(currentUser);
                    }
                }

                counter++;
                input = Console.ReadLine();
            }

            foreach (var kvp in emailsDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
