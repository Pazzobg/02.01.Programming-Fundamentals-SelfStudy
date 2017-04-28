namespace _03.PrintingTriangle_2
{
    using System;

    public class PrintingTriangle_2
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangleBody(input);
        }

        public static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        public static void PrintTriangleBody(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                PrintLine(1, i);
            }

            for (int i = input - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
