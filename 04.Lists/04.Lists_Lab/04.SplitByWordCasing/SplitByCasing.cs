namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByCasing
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            var wordsList = text.Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCaseList = new List<string>();
            var upperCaseList = new List<string>();
            var mixedCaseList = new List<string>();

            foreach (var word in wordsList)
            {
                int smallLetters = 0;
                int capitalLetters = 0;

                foreach (char letter in word)
                {
                    if (letter >= 65 && letter <= 90)
                    {
                        capitalLetters++;
                    }
                    else if (letter >= 97 && letter <= 122)
                    {
                        smallLetters++;
                    }
                    else
                    {
                        smallLetters++;
                        capitalLetters++;
                    }
                }

                if (capitalLetters > 0 && smallLetters == 0)
                {
                    upperCaseList.Add(word);
                }
                else if (smallLetters > 0 && capitalLetters == 0)
                {
                    lowerCaseList.Add(word);
                }
                else
                {
                    mixedCaseList.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseList)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseList)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseList)}");
        }
    }
}
