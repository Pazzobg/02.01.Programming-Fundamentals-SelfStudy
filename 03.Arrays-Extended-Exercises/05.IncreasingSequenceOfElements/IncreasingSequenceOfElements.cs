namespace _05.IncreasingSequenceOfElements
{
    using System;
    using System.Linq;

    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool increase = true;
            int previousNum = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < previousNum)
                {
                    increase = false;
                }

                previousNum = arr[i];
            }

            if (increase)
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
