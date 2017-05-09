namespace _02.ArrayElementsEqualtToTheirIndex
{
    using System;
    using System.Linq;

    public class ArrayElementsEqualToIndex
    {
        public static void Main()
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] == i)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }
    }
}
