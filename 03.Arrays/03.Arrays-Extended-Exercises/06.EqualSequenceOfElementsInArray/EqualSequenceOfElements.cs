namespace _06.EqualSequenceOfElementsInArray
{
    using System;
    using System.Linq;

    public class EqualSequenceOfElements
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int previousNum = arr[0];
            bool equal = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != previousNum)
                {
                    equal = false;
                }
            }

            if (equal)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
