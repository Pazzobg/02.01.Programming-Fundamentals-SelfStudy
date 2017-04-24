using System;

namespace _18.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                long inputNumber = long.Parse(input);

                if (inputNumber >= long.MinValue && inputNumber <= long.MaxValue)
                {
                    Console.WriteLine($"{inputNumber} can fit in:");

                    if ((inputNumber >= sbyte.MinValue) && (inputNumber <= sbyte.MaxValue)) Console.WriteLine("* sbyte");
                    if ((inputNumber >= byte.MinValue) && (inputNumber <= byte.MaxValue)) Console.WriteLine("* byte");
                    if ((inputNumber >= short.MinValue) && (inputNumber <= short.MaxValue)) Console.WriteLine("* short");
                    if ((inputNumber >= ushort.MinValue) && (inputNumber <= ushort.MaxValue)) Console.WriteLine("* ushort");
                    if ((inputNumber >= int.MinValue) && (inputNumber <= int.MaxValue)) Console.WriteLine("* int");
                    if ((inputNumber >= uint.MinValue) && (inputNumber <= uint.MaxValue)) Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
            }
            catch
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
