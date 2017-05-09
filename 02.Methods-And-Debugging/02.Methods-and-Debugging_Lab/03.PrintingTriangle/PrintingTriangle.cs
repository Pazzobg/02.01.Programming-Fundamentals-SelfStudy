namespace _03.PrintingTriangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
        }

        public static void PrintTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintTriangleBody(row);
            }

            for (int row = number - 1; row >= 1; row--)
            {
                PrintTriangleBody(row);
            }
        }

        public static void PrintTriangleBody(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }

            Console.WriteLine();
        }
    }
}
