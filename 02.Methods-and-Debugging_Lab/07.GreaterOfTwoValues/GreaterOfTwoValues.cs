namespace _07.GreaterOfTwoValues
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int inputOne = int.Parse(Console.ReadLine());
                int inputTwo = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(inputOne, inputTwo));
            }
            else if (type == "char")
            {
                char inputOne = char.Parse(Console.ReadLine());
                char inputTwo = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(inputOne, inputTwo));
            }
            else
            {
                string inputOne = Console.ReadLine();
                string inputTwo = Console.ReadLine();

                Console.WriteLine(GetMax(inputOne, inputTwo));
            }
        }

        public static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        public static char GetMax(char first, char second)
        {
            return (char)GetMax((int)first, (int)second);
        }

        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
