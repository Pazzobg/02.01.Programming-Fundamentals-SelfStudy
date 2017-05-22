namespace _03.IncreasingCrisis
{
    using System;
    using System.Collections.Generic;

    public class IncreasingCrisis
    {
        public static void Main()
        {
            /*
             * You will be given N – an integer. On the next N lines, you will receive sequences of integers, 
             * separated by a space.
             * Your task is to add each sequence’s integers to a list, so that it forms an increasing sequence. 
             * If there are already elements inside the list, you must find the right-most element, 
             * lower by value than the first element from the given sequence, and start INSERTING, 
             * the sequence’s elements at the position, AFTER the found element.
             * If the increasing sequence is BROKEN during the addition of new elements, you must IGNORE the element 
             * that breaks it and all others after it. You must also remove all elements from the list, 
             * AFTER the LAST ADDED element.
             * When you process all input lines, you must print the list’s elements, separated by a single space.
             * 
             * Constraints
             * •	The list, to which you add the elements, is initially empty.
             * •	The increasing sequence CAN have EQUAL elements.
             * •	Do NOT sort the list in any order. 
             * Examples
             * Input	            Output	            Comment
             * 5
             * 1 2 12 15 16         1 2 3 3 4 5 6       The list is initially empty, so we add [1, 2, 12, 15, 16] to it.
             * 4 5 6                                    After that we have [4, 5, 6]. We find the right-most element,
             * 5 5 5                                    lower by value than the first element (4), 
             * 3 2                                      which is 2, and we start INSERTING AFTER it.
             * 3 4 5 6		
             *                                          The list is now [1, 2, 4, 5, 6, 12, 15, 16].
             *  
             *                                          + 5 5 5 -> [1, 2, 4, 5, 5, 5, 5, 6, 12, 15, 16].
             * 
             *                                          Of the sequence [3, 2] we insert 3.
             * 
             *                                          The 2nd element of the sequence (2) BREAKS the increasing sequence, 
             *                                          and so we ignore it, and we remove all elements after the 
             *                                          last added (3), which results in
             *                                          [1, 2, 3].
             * 
             *                                          Then we have [3, 4, 5, 6] -> [1, 2, 3, 3, 4, 5, 6]
             * Input	            Output
             * 4                    
             * 1 2                  1 2 2 2 3 4 5
             * 2 1
             * 2 3
             * 4 5 1 6 7	
             */

            int n = int.Parse(Console.ReadLine());

            var totalList = new List<int>();

            for (int inputsLoop = 0; inputsLoop < n; inputsLoop++)
            {
                string[] input = Console.ReadLine().Split(' ');
                var currentList = new List<int>();
                for (int addingToCurrent = 0; addingToCurrent < input.Length; addingToCurrent++)
                {
                    currentList.Add(int.Parse(input[addingToCurrent]));
                }

                if (inputsLoop == 0)
                {
                    for (int j = 0; j < currentList.Count; j++)
                    {
                        totalList.Add(currentList[j]);
                    }

                    continue;
                }
                else
                {
                    int firstFromCurrent = currentList[0];
                    int rightMost = 0;

                    for (rightMost = totalList.Count - 1; rightMost >= 0; rightMost--)
                    {
                        if (totalList[rightMost] <= firstFromCurrent)
                        {
                            break;
                        }
                    }

                    if (rightMost == totalList.Count - 1)
                    {
                        totalList.AddRange(currentList);
                    }
                    else
                    {
                        int insIndex = InsLookUp(totalList, currentList);   //tuk i v metoda e posl test
                        var insEnd = insIndex + currentList.Count;
                        var count = 0;
                        for (int position = insIndex; position < insEnd; position++)
                        {
                            totalList.Insert(position, currentList[count]);
                            count++;
                            if (totalList[position] > totalList[position + 1])
                            {
                                break;
                            }
                        }
                    }

                    SecondaryCheckTotalList(totalList);
                }
            }

            Console.WriteLine(string.Join(" ", totalList));
        }

        public static int InsLookUp(List<int> totalList, List<int> currentList)
        {
            int insStart = 0;
            for (int i = 0; i < totalList.Count; i++)
            {
                if (totalList[i] > currentList[0])
                {
                    insStart = i;
                    break;
                }
            }

            return insStart;
        }

        public static void SecondaryCheckTotalList(List<int> totalList)
        {
            for (int j = 0; j < totalList.Count - 1; j++)
            {
                int next = j + 1;
                int count = totalList.Count - next;

                if (totalList[j] > totalList[next])
                {
                    totalList.RemoveRange(next, count);
                    break;
                }
            }
        }
    }
}
