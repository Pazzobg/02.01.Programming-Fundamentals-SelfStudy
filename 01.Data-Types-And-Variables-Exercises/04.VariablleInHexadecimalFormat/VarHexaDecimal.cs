using System;

namespace _04.VariablleInHexadecimalFormat
{
    class VarHexaDecimal
    {
        static void Main(string[] args)
        {
            //One - row solution:
            //Console.WriteLine(Convert.ToInt32(Console.ReadLine(), 16));

            string input = Console.ReadLine();

            var target = Convert.ToInt32(input, 16);
            Console.WriteLine(target);
        }
    }
}
