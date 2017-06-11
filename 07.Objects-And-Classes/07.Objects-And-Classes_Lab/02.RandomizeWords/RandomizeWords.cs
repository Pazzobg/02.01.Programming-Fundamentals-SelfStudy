namespace _02.RandomizeWords
{
    using System;

    public class RandomizeWords
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');

            var random = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                string currentWord = text[i];
                int newRandomPosition = random.Next(0, text.Length);

                string tempStringHolder = text[i];

                text[i] = text[newRandomPosition];
                text[newRandomPosition] = tempStringHolder;
            }

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
