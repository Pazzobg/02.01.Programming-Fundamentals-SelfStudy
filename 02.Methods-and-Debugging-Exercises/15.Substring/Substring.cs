namespace _15.Substring
{
    using System;

    public class Substring
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            bool match = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    match = true;

                    int endIndex = count + 1;
                    string matchedString = string.Empty;

                    if (i + endIndex <= text.Length)
                    {
                        matchedString = text.Substring(i, endIndex);
                    }
                    else
                    {
                        matchedString = text.Substring(i);
                    }

                    Console.WriteLine(matchedString);
                    i += count;
                }
            }

            if (!match)
            {
                Console.WriteLine("no");
            }
        }
    }
}
