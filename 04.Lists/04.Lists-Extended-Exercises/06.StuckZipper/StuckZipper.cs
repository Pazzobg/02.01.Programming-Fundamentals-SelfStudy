namespace _06.StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StuckZipper
    {
        public static void Main()
        {
            var topList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bottomList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var resultList = new List<int>();

            int smallestNum = FinderSmallestNum(topList, bottomList);

            topList = RemoverBiggerNums(topList, smallestNum);
            bottomList = RemoverBiggerNums(bottomList, smallestNum);

            int loopEnd = Math.Max(topList.Count, bottomList.Count);

            for (int i = 0; i < loopEnd; i++)
            {
                if (i < bottomList.Count)
                {
                    resultList.Add(bottomList[i]);
                }

                if (i < topList.Count)
                {
                    resultList.Add(topList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }

        public static int FinderSmallestNum(List<int> topList, List<int> bottomList)
        {
            int smallestFromTop = int.MaxValue;
            int smallestFromBottom = int.MaxValue;

            for (int i = 0; i < topList.Count; i++)
            {
                if (Math.Abs(topList[i]) < smallestFromTop)
                {
                    smallestFromTop = Math.Abs(topList[i]);
                }
            }

            for (int i = 0; i < bottomList.Count; i++)
            {
                if (Math.Abs(bottomList[i]) < smallestFromBottom)
                {
                    smallestFromBottom = Math.Abs(bottomList[i]);
                }
            }

            return Math.Min(smallestFromTop, smallestFromBottom);
        }

        public static List<int> RemoverBiggerNums(List<int> currentList, int smallestNum)
        {
            if (smallestNum < 10)
            {
                for (int i = 0; i < currentList.Count; i++)
                {
                    if (currentList[i] >= 10)
                    {
                        currentList.Remove(currentList[i]);
                        i--;
                    }
                }
            }
            else if (smallestNum < 100)
            {
                for (int i = 0; i < currentList.Count; i++)
                {
                    if (currentList[i] >= 100)
                    {
                        currentList.Remove(currentList[i]);
                        i--;
                    }
                }
            }
            else if (smallestNum < 1000)
            {
                for (int i = 0; i < currentList.Count; i++)
                {
                    if (currentList[i] >= 1000)
                    {
                        currentList.Remove(currentList[i]);
                        i--;
                    }
                }
            }
            else if (smallestNum < 10000)
            {
                for (int i = 0; i < currentList.Count; i++)
                {
                    if (currentList[i] >= 10000)
                    {
                        currentList.Remove(currentList[i]);
                        i--;
                    }
                }
            }
            else if (smallestNum < 100000)
            {
                for (int i = 0; i < currentList.Count; i++)
                {
                    if (currentList[i] >= 100000)
                    {
                        currentList.Remove(currentList[i]);
                        i--;
                    }
                }
            }
            else if (smallestNum < 1000000)
            {
                for (int i = 0; i < currentList.Count; i++)
                {
                    if (currentList[i] >= 1000000)
                    {
                        currentList.Remove(currentList[i]);
                        i--;
                    }
                }
            }

            return currentList;
        }
    }
}
