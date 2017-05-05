namespace _05.RoundingNumbers
{
    using System;
    using System.Linq;

    public class RoundingNumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] digits = input.Split(' ');
            var numbers = new double[digits.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(digits[i]);
            }

            //var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double roundedValue = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundedValue}");
            }
        }
    }
}
