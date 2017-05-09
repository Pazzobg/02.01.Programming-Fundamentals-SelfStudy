namespace _01.LastThreeConsecutiveEqualStrings
{
    using System;

    public class LastThreeEqualStrings
    {
        public static void Main()
        {
            string[] inputArr = Console.ReadLine().Split(' ');

            for (int i = inputArr.Length - 1; i >= 2; i--)
            {
                if (inputArr[i] == inputArr[i - 1] && inputArr[i - 1] == inputArr[i - 2])
                {
                    Console.WriteLine($"{inputArr[i]} {inputArr[i]} {inputArr[i]}");
                    break;
                }
            }
        }
    }
}
