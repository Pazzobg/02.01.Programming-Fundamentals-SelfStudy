namespace _05.CapitalizeWords
{
    using System;
    using System.Collections.Generic;

    public class CapitalizeWords
    {
        public static void Main()
        {
            char[] delimiters = " ~!@#$%^&*()_+`-={}|[]\\:\";<>?,./".ToCharArray();

            var sentence = Console.ReadLine().ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            while (sentence[0] != "end")
            {
                var result = new List<string>();

                foreach (var word in sentence)
                {
                    string newWord = string.Empty;

                    for (int i = 0; i < word.Length; i++)
                    {
                        var currentChar = word[i].ToString();

                        if (i == 0)
                        {
                            currentChar = currentChar.ToUpper();
                        }

                        newWord += currentChar;
                    }

                    result.Add(newWord);
                }

                Console.WriteLine(string.Join(", ", result));

                sentence = Console.ReadLine().ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
