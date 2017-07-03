namespace _04.Nilapdromes
{
    using System;
    using System.Text.RegularExpressions;

    public class Nilapdromes
    {
        public static void Main()
        {
            string pattern = @"\b([a-zA-Z]+)([a-zA-Z]+)\1\b";
            var regex = new Regex(pattern);

            string input = Console.ReadLine();

            while (input != "end")
            {
                var match = regex.Match(input);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string primalBorder = match.Groups[1].Value;
                string primalCore = match.Groups[2].Value;

                Console.WriteLine($"{primalCore}{primalBorder}{primalCore}");

                input = Console.ReadLine();
            }
        }
    }
}