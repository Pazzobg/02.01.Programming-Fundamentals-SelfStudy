namespace _02.AverageCharacterDelimiter
{
    using System;
    using System.Collections.Generic;

    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            int sumOfCharValues = 0;
            int totalCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                word.ToCharArray();

                foreach (char letter in word)
                {
                    sumOfCharValues += letter;
                    totalCount++;
                }
            }

            int average = sumOfCharValues / totalCount;

            if (average >= 97 && average <= 122)
            {
                average -= 32;
            }

            char averageChar = (char)average;

            Console.WriteLine(string.Join($"{averageChar}", input));
        }
    }
}
