using System;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            //Two-step convertion into hex + printing:
            int input = int.Parse(Console.ReadLine());
            string hexValue = Convert.ToString(input, 16);
            Console.WriteLine(hexValue.ToUpper());
            Console.WriteLine(Convert.ToString(input, 2));

            //One-step convertion and printing of the hex value: 
            //Console.WriteLine((Convert.ToString(input, 16)).ToUpper());
            //Console.WriteLine(Convert.ToString(input, 2));

            //Another one-step solution for the hex convertion: 
            //Console.WriteLine(input.ToString("X"));
            //If we put lower-case x in the brackets the result is printed in lower-case, e.g.: "8fe4"
        }
    }
}
