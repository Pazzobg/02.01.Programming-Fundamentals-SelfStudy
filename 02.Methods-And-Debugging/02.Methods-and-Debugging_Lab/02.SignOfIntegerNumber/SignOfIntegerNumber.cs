﻿namespace _02.SignOfIntegerNumber
{
    using System;

    public class SignOfIntegerNumber
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintIntSign(n);
        }

        public static void PrintIntSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
