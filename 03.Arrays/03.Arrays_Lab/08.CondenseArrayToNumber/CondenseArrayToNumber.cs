namespace _08.CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = 0;

            if (numbers.Length == 1)
            {
                result = numbers[0];
            }

            while (numbers.Length > 1)
            {
                var condensed = new int[numbers.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condensed;
                result = condensed[0];
            }

            Console.WriteLine(result);
        }
    }
}