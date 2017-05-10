namespace _09.IndexOfLetters
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            char letter = 'a';
            char[] lettersArray = new char[26];
            for (int i = 0; i < lettersArray.Length; i++, letter++) // Assigning an array with alphabetical letters
            {
                lettersArray[i] = letter;
            }

            char[] input = Console.ReadLine().ToLower().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < lettersArray.Length; j++) // Comparing each letter from the input with the alphabet
                {                                       // array and in case of a match, printing out the array index
                    if (input[i] == lettersArray[j])    // of the particular letter
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }

            /*  Shorter solution: 
             * char[] input = Console.ReadLine().ToCharArray();
             *
             * for (int i = 0; i < input.Length; i++)
             * {
             *     Console.WriteLine("{0} -> {1}", input[i], input[i] - 'a');
             * }
             */
        }
    }
}
