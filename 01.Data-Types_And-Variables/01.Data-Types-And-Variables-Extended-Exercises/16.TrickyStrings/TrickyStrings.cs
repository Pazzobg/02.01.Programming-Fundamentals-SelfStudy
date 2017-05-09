using System;

namespace _16.TrickyStrings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    string input = Console.ReadLine();
                    result += input + delimiter;
                }
                else
                {
                    string input = Console.ReadLine();
                    result += input;
                }
            }
            Console.WriteLine(result);
        }
    }
}
