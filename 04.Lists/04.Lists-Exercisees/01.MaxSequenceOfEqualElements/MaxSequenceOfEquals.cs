namespace _01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEquals
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int counter = 1;
            int longestSeq = 1;
            int longestSeqMember = 0;

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i + 1] == inputList[i])
                {
                    counter++;

                    if (counter > longestSeq)
                    {
                        longestSeq = counter;
                        longestSeqMember = inputList[i];
                    }
                }
                else
                {
                    counter = 1;
                }

                if (longestSeq == 1)
                {
                    longestSeqMember = inputList[0];
                }
            }

            for (int i = 0; i < longestSeq; i++)
            {
                Console.Write(longestSeqMember + " ");
            }
        }
    }
}
