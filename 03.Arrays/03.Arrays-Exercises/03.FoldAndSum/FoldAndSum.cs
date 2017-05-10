namespace _03.FoldAndSum
{
    using System;

    public class FoldAndSum
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');
            int length = items.Length;
            int[] numsArr = new int[length];

            for (int i = 0; i < length; i++)
            {
                numsArr[i] = int.Parse(items[i]);
            }

            int k = numsArr.Length / 4;

            int[] topLeft = ArrayBreakerTopLeft(numsArr, k);
            int[] topRight = ArrayBreakerTopRight(numsArr, k);
            int[] bottomBase = ArrayBreakerBottomBase(numsArr, k);

            int[] outputArray = new int[k * 2];

            Array.Reverse(topLeft);
            Array.Reverse(topRight);

            for (int i = 0; i < k; i++)
            {
                outputArray[i] = topLeft[i] + bottomBase[i];
            }

            for (int i = 0; i < k; i++)
            {
                outputArray[k + i] = topRight[i] + bottomBase[k + i];
            }

            Console.WriteLine(string.Join(" ", outputArray));
        }

        public static int[] ArrayBreakerTopLeft(int[] numsArr, int k)
        {
            int[] topLeft = new int[k];

            for (int i = 0; i < k; i++)
            {
                topLeft[i] = numsArr[i];
            }

            return topLeft;
        }

        public static int[] ArrayBreakerTopRight(int[] numsArr, int k)
        {
            int[] topRight = new int[k];

            for (int i = 0; i < k; i++)
            {
                topRight[i] = numsArr[i + (3 * k)];
            }

            return topRight;
        }

        public static int[] ArrayBreakerBottomBase(int[] numsArr, int k)
        {
            int[] bottomBase = new int[k * 2];

            for (int i = 0; i < 2 * k; i++)
            {
                bottomBase[i] = numsArr[i + k];
            }

            return bottomBase;
        }
    }
}
