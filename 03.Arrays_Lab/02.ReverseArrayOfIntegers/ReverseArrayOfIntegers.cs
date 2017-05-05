namespace _02.ReverseArrayOfIntegers
{
    using System;

    public class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrayValues = new int[n];

            for (int i = 0; i < arrayValues.Length; i++)
            {
                arrayValues[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arrayValues.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arrayValues[i]} ");
            }

            Console.WriteLine();
        }
    }
}
