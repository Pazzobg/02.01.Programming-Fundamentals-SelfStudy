namespace _01.RemoveNegativeAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativeReverse
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var resultList = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] > 0)
                {
                    resultList.Add(inputList[i]);
                }
            }

            resultList.Reverse();

            //for (int i = inputList.Count - 1; i >= 0; i--)
            //{
            //    if (inputList[i] > 0)
            //    {
            //        resultList.Add(inputList[i]);
            //    }
            //}

            if (resultList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", resultList));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
