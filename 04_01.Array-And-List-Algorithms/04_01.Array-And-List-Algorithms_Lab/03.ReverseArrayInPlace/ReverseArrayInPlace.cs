namespace _03.ReverseArrayInPlace
{
    using System;
    using System.Linq;

    public class ReverseArrayInPlace
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int temp = 0;
            int loopEnd = numbers.Count / 2;

            for (int i = 0; i < loopEnd; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
