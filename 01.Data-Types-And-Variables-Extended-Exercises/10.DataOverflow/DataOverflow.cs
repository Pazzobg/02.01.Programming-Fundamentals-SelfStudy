using System;

namespace _10.DataOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal lower = Math.Min(num1, num2);
            decimal greater = Math.Max(num1, num2);
            string typeSmaller = "";
            string typeBigger = "";
            decimal overflow = 0;

            if (lower >= byte.MinValue && lower <= byte.MaxValue) typeSmaller = "byte";
            else if (lower >= ushort.MinValue && lower <= ushort.MaxValue) typeSmaller = "ushort";
            else if (lower >= uint.MinValue && lower <= uint.MaxValue) typeSmaller = "uint";
            else if (lower >= ulong.MinValue && lower <= ulong.MaxValue) typeSmaller = "ulong";


            if (greater >= byte.MinValue && greater <= byte.MaxValue) typeBigger = "byte";
            else if (greater >= ushort.MinValue && greater <= ushort.MaxValue) typeBigger = "ushort";
            else if (greater >= uint.MinValue && greater <= uint.MaxValue) typeBigger = "uint";
            else if (greater >= ulong.MinValue && greater <= ulong.MaxValue) typeBigger = "ulong";

            if (typeSmaller == "byte") overflow = Math.Round(greater / byte.MaxValue);
            else if (typeSmaller == "ushort") overflow = Math.Round(greater / ushort.MaxValue);
            else if (typeSmaller == "uint") overflow = Math.Round(greater / uint.MaxValue);
            else if (typeSmaller == "ulong") overflow = Math.Round(greater / ulong.MaxValue);

            Console.WriteLine($"bigger type: {typeBigger}\nsmaller type: {typeSmaller}");
            Console.WriteLine($"{greater} can overflow {typeSmaller} {overflow} times");
        }
    }
}
