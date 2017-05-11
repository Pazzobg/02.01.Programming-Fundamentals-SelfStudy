namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            string[] inputList = Console.ReadLine().Split('|');

            var resultList = new List<string>();

            for (int i = inputList.Length - 1; i >= 0; i--)
            {
                inputList[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                resultList.Add(inputList[i]);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }

            //string[] input = Console.ReadLine().Split('|');

            //List <string> result = new List<string>();

            //Array.Reverse(input);

            //foreach (var item in input)
            //{
            //    if (item != " ")
            //    {
            //        result.Add(item);
            //    }
            //}

            //Console.WriteLine(string.Join(" ", result));
    }
}
