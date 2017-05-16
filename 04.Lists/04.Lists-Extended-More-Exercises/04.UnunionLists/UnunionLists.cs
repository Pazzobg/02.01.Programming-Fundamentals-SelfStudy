namespace _04.UnunionLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnunionLists
    {
        public static void Main()
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());
            bool foundInPrimal = false;

            for (int i = 0; i < n; i++)
            {
                var currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < currentList.Count; j++)
                {
                    foundInPrimal = false;

                    for (int k = 0; k < primalList.Count; k++)
                    {
                        if (currentList[j] == primalList[k])
                        {
                            foundInPrimal = true;
                            primalList.Remove(primalList[k]);
                            k--;
                        }
                    }

                    if (foundInPrimal == false)
                    {
                        primalList.Add(currentList[j]);
                    }
                }
            }

            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
