namespace _04.DrawAFilledSquare
{
    using System;

    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            PrintWholeSquare(input);
        }

        public static void PrintSquareStartEnd(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        public static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }

        public static void PrintWholeSquare(int n)
        {
            int limit = n - 2;
            PrintSquareStartEnd(n);

            for (int i = 0; i < limit; i++)
            {
                PrintMiddleRow(n);
            }

            PrintSquareStartEnd(n);
        }
    }
}
