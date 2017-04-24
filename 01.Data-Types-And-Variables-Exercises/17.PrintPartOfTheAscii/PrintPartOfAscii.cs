using System;

namespace _17.PrintPartOfTheAscii
{
    class PrintPartOfAscii
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= endChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
