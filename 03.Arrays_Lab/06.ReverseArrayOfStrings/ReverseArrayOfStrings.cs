namespace _06.ReverseArrayOfStrings
{
    using System;

    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            string[] reversedArray = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - i - 1];
            }

            string result = string.Join(" ", reversedArray);
            Console.WriteLine(result);
        }
    }
}
