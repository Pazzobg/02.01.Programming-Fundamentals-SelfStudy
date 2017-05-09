namespace _01.HelloName
{
    using System;

    public class HelloName
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            PrintName(input);
        }

        public static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
