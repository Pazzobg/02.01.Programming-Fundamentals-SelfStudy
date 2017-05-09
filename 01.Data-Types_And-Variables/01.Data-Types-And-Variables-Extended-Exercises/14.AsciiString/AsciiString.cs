using System;

namespace _14.AsciiString
{
    class AsciiString
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string output = "";

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                char currentChar = (char)input;
                output += currentChar.ToString();
            }
            Console.WriteLine(output);
        }
    }
}
