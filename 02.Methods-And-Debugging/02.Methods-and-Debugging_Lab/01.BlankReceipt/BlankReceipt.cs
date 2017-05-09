namespace _01.BlankReceipt
{
    using System;

    public class BlankReceipt
    {
        public static void Main()
        {
            Console.WriteLine("CASH RECEIPT");

            PrintWholeReceipt();

            Console.WriteLine("\u00A9 SoftUni");
        }

        public static void PrintReceiptHeader()
        {
            Console.WriteLine(new string('-', 30));
        }

        public static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintReceiptFooter()
        {
            PrintReceiptHeader();
        }

        public static void PrintWholeReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }
    }
}
