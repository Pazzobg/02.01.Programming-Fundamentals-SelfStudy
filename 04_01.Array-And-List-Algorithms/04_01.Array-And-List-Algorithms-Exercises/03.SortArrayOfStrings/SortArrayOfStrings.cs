namespace _03.SortArrayOfStrings
{
    using System;
    using System.Collections.Generic;

    public class SortArrayOfStrings
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 1; i < input.Length; i++)
                {
                    int prev = i - 1;
                    int current = i;
                    int check = input[current].CompareTo(input[prev]);

                    if (check < 0)
                    {
                        string temp = input[prev];
                        input[prev] = input[current];
                        input[current] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
