namespace _02.RotateAndSum
{
    using System;

    public class RotateAndSum
    {
        public static void Main()
        {
            string inputArr = Console.ReadLine();
            var items = inputArr.Split(' ');
            int[] numbers = new int[items.Length];
            int loopEnd = items.Length;

            /* var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  -  using this instead of the longer
             * version above increases Perf time and resources: Time is increased from 0.015s to 0.031s, Memory from 
             * 8.25MB to 8.92MB*/


            for (int i = 0; i < loopEnd; i++)
            {
                numbers[i] = int.Parse(items[i]);
            }

            int rotate = int.Parse(Console.ReadLine());

            int[] sum = new int[loopEnd];

            for (int i = 0; i < rotate; i++)
            {
                int[] rotatedArr = new int[loopEnd];

                rotatedArr[0] = numbers[loopEnd - 1];

                for (int j = 0; j < loopEnd - 1; j++)
                {
                    rotatedArr[j + 1] = numbers[j];
                }

                for (int k = 0; k < loopEnd; k++)
                {
                    sum[k] += rotatedArr[k];
                }

                numbers = rotatedArr;
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
