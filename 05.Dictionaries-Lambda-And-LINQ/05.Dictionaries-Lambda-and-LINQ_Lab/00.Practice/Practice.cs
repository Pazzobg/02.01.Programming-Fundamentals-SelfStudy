namespace _00.Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Practice
    {
        public static void Main()
        {
            var numbers = new List<int> { 1, 3, 2, 5, 4 };
            var hasNumbers = numbers.Any(n => n > 8);

            var maxThreeNumbers = numbers.Where(n => n % 3 == 0).ToList();



            Console.WriteLine(hasNumbers);

            //numbers = numbers.OrderBy(n => n).ToList();
            //Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
