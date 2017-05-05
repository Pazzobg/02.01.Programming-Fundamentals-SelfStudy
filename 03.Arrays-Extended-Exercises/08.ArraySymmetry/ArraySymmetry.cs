namespace _08.ArraySymmetry
{
    using System;

    public class ArraySymmetry
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            bool equal = true;
            int check = arr.Length;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[check - 1 - i])
                {
                    equal = false;
                }
            }

            if (equal)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
