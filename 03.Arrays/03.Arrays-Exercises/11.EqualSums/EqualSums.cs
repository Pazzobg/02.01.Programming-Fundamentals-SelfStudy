namespace _11.EqualSums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool found = false;

            if (numbers.Length == 1)        // if array consists of only one element, as per problem conditions, sum
            {                               // of "left" and "right" is equal.
                Console.WriteLine("0");
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = CalculateSumLeft(numbers, i);
                rightSum = CalculateSumRight(numbers, i);

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);                       
                    found = true;
                    return;
                }
            }

            if (found == false)
            {
                Console.WriteLine("no");
            }
        }

        public static int CalculateSumLeft(int[] nums, int i)  // Calculates the sum of all elements back from current 
        {                                                      // value of i to the beginning of the array.
            int sum = 0;                                       
            for (int j = i; j >= 0; j--)                             
            {
                sum += nums[j];                                   
            }

            return sum;
        }

        public static int CalculateSumRight(int[] nums, int i) // Calculates sum of all elements from current value of i 
        {                                                      // to the end of the array.
            int sum = 0;                                       
                                                               
            for (int j = i; j < nums.Length; j++)                
            {
                sum += nums[j];
            }

            return sum;
        }
    }
}