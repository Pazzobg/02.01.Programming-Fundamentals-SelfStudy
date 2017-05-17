namespace _05.BombNumbers_02
{
    using System;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] bombProperties = Console.ReadLine().Split(' ');

            int bomb = int.Parse(bombProperties[0]);
            int bombPower = int.Parse(bombProperties[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int left = Math.Max(i - bombPower, 0);

                    int right = Math.Min(i + bombPower, numbers.Count - 1);

                    int length = right - left + 1;

                    numbers.RemoveRange(left, length);

                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
