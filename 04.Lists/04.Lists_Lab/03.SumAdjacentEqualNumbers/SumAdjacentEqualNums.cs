namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNums
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 1; i < inputList.Count; i++)
            {
                if (inputList[i] == inputList[i - 1])
                {
                    inputList[i - 1] *= 2;
                    inputList.Remove(inputList[i]);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
