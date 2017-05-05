namespace _03.CountOfGivenElementInArray
{
    using System;
    using System.Linq;

    public class CountOfGivenElement
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int specialNumber = int.Parse(Console.ReadLine());
            int foundCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    foundCounter++;
                }
            }

            Console.WriteLine(foundCounter);
        }
    }
}
