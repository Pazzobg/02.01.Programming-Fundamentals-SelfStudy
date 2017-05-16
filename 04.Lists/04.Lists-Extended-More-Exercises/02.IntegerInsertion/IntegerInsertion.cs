namespace _02.IntegerInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string nextInput = Console.ReadLine();
            int currentNum = 0;

            while (nextInput != "end")
            {
                char firstDigit = nextInput[0];
                int position = firstDigit - '0';
                currentNum = int.Parse(nextInput);

                inputList.Insert(position, currentNum);

                nextInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
