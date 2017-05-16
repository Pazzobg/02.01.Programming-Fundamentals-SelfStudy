namespace _01.DistinctList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = i + 1; j < inputList.Count; j++)
                {
                    if (inputList[j] == inputList[i])
                    {
                        inputList.RemoveAt(j);
                        j--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
