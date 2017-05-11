namespace _05.SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            inputList.Sort();

            Console.WriteLine(string.Join(" <= ", inputList)); 
        }
    }
}
