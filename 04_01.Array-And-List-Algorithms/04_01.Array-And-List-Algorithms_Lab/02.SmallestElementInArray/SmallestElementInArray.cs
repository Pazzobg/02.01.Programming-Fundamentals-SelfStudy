namespace _02.SmallestElementInArray
{
    using System;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int smallestNum = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < smallestNum)
                {
                    smallestNum = numbers[i];
                }
            }

            Console.WriteLine(smallestNum);
        }
    }
}
