namespace _01.ArrayContainsElement
{
    using System;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int neededElement = int.Parse(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == neededElement)
                {
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
