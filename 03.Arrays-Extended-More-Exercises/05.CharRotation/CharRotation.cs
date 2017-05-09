namespace _05.CharRotation
{
    using System;
    using System.Linq;

    public class CharRotation
    {
        public static void Main()
        {
            char[] characters = Console.ReadLine().ToCharArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    char current = characters[i];
                    current -= (char)numbers[i];
                    characters[i] = current;
                }
                else
                {
                    char current = characters[i];
                    current += (char)numbers[i];
                    characters[i] = current;
                }
            }

            Console.WriteLine(string.Join(string.Empty, characters));
        }
    }
}
