namespace _04.RotateArrayOfStrings
{
    using System;
    using System.Linq;

    public class RotateArrayOfStrings
    {
        public static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            string rotatedArr = StringRotator(arr);

            Console.WriteLine(string.Join(" ", rotatedArr));
        }

        public static string StringRotator(string[] arr)
        {
            string[] rotatedArr = new string[arr.Length];
            rotatedArr[0] = arr[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                rotatedArr[i + 1] = arr[i];
            }

            string resultAsString = string.Join(" ", rotatedArr);
            return resultAsString;
        }
    }
}
