namespace _02.MulitplyAnArrayOfDoubles
{
    using System;
    using System.Linq;

    public class MultiplyArrayOfDoubles
    {
        public static void Main()
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double multiplier = double.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= multiplier;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
