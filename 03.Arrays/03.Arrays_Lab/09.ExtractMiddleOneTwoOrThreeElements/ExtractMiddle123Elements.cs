namespace _09.ExtractMiddleOneTwoOrThreeElements
{
    using System;
    using System.Linq;

    public class ExtractMiddle123Elements
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (arr.Length == 1)
            {
                ExtractSingleInput(arr);
            }
            else if (arr.Length % 2 == 0)
            {
                ExtractMiddleTwoOfEvenInput(arr);
            }
            else
            {
                ExctractMiddleThreeOfOddInput(arr);
            }
        }

        public static void ExtractSingleInput(int[] inputArr)
        {
            Console.WriteLine($"{{ {inputArr[0]} }}");
        }

        public static void ExtractMiddleTwoOfEvenInput(int[] inputArr)
        {
            var result = new int[2];
            result[0] = inputArr[(inputArr.Length / 2) - 1];
            result[1] = inputArr[inputArr.Length / 2];
            Console.WriteLine($"{{ {string.Join(", ", result)} }}");
        }

        public static void ExctractMiddleThreeOfOddInput(int[] inputArr)
        {
            var result = new int[3];
            result[0] = inputArr[(inputArr.Length / 2) - 1];
            result[1] = inputArr[inputArr.Length / 2];
            result[2] = inputArr[(inputArr.Length / 2) + 1];
            Console.WriteLine($"{{ {string.Join(", ", result)} }}");
        }
    }
}
