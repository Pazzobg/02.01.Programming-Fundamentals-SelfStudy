namespace _01.Placeholders
{
    using System;

    public class Placeholders
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                string sentence = input[0].Trim();
                string[] elements = input[1].Trim().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    string currentPlaceholder = "{" + i + "}"; // {0}

                    sentence = sentence.Replace(currentPlaceholder, elements[i]);
                }

                Console.WriteLine(sentence);

                input = Console.ReadLine().Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
