namespace _04.LargestThreeNumbers
{
    using System;
    using System.Linq;
    
    public class LargestThreeNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sortedLargestThree = numbers.OrderByDescending(n => n).Take(3);
            Console.WriteLine(string.Join(" ", sortedLargestThree));
        }
    }
}
