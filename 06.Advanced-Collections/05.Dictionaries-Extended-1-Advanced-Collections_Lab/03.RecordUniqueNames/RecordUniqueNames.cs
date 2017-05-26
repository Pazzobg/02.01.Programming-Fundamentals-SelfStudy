namespace _03.RecordUniqueNames
{
    using System;
    using System.Collections.Generic;

    public class RecordUniqueNames
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var namesList = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                namesList.Add(input);
            }

            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }

            //Solution with List<T> and if-check:

            //int n = int.Parse(Console.ReadLine());

            //var namesList = new List<string>();

            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    if (!namesList.Contains(input))
            //    {
            //        namesList.Add(input);
            //    }
            //}

            //foreach (var name in namesList)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
