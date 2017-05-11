namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var outputList = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                int currentNum = inputList[i];

                // if (Math.Sqrt(currentNum) % 1 == 0)
                // {
                //     outputList.Add(currentNum);
                // }

                if (Math.Sqrt(currentNum) == (int)Math.Sqrt(currentNum))
                {
                    outputList.Add(currentNum);
                }
            }

            // outputList.Sort();
            // outputList.Reverse();

            outputList.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}
