namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNums
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int counter = 1;

            inputList.Sort();
            int i = 0;
            for (i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{inputList[i]} -> {counter}");
                    counter = 1;
                }
            }

            Console.WriteLine($"{inputList[i]} -> {counter}");
        }
    }
}
