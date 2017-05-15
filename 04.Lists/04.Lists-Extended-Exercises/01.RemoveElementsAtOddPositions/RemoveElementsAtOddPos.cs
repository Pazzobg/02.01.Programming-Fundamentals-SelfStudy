namespace _01.RemoveElementsAtOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveElementsAtOddPos
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').ToList();
            var outputList = new List<string>();
            for (int i = 0; i < inputList.Count; i++)
            {
                inputList.RemoveAt(i);
            }

            Console.WriteLine(string.Join(string.Empty, inputList));

            /* Another solution: 
             * 
             * for (int i = 0; i < inputList.Count; i++)
               {
                   if (i % 2 != 0)
                   {
                       outputList.Add(inputList[i]);
                   }
               }

             * Console.WriteLine(string.Join(string.Empty, outputList));*/

        }
    }
}
