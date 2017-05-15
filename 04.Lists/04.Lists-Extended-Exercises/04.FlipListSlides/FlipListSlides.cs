namespace _04.FlipListSlides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlipListSlides
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1; i < inputList.Count / 2; i++)
            {
                int temp = inputList[i];
                inputList[i] = inputList[inputList.Count - i - 1];
                inputList[inputList.Count - i - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
