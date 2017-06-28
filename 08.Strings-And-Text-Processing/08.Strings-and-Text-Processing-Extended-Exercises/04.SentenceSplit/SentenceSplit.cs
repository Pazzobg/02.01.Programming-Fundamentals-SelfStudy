namespace _04.SentenceSplit
{
    using System;

    public class SentenceSplit
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();

            string[] result = sentence.Split(new string[] { Console.ReadLine() }, StringSplitOptions.None);

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}