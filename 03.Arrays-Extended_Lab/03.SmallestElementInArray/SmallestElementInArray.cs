namespace _03.SmallestElementInArray
{
    using System;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ExtractingSmallestIntFromArray(arr);
        }

        public static void ExtractingSmallestIntFromArray(int[] arr)
        {
            int smallestElement = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallestElement)
                {
                    smallestElement = arr[i];
                }
            }

            Console.WriteLine(smallestElement);

            //one-line solution: 
            //Console.WriteLine(arr.Min());
        }
    }
}
