namespace _00.Practice
{
using System;

    public class Practice
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            foreach (char symbol in number.ToString())
            {
                int digit = symbol - '0';
                Console.WriteLine(digit);
            }
        }
    }
}