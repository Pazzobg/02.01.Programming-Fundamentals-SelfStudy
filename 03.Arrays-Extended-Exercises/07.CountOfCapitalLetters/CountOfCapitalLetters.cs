namespace _07.CountOfCapitalLetters
{
    using System;
    using System.Linq;

    public class CountOfCapitalLetters
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                if (words[i].Length == 1)
                {
                    char currentChar = currentWord[0];

                    if (currentChar >= 65 && currentChar <= 90)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
