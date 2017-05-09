namespace _04.NumbersInReversedOrder
{
    using System;

    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            string input = double.Parse(Console.ReadLine()).ToString();

            string newReversed = ReverseString(input);

            Console.WriteLine(newReversed);
        }

        public static string ReverseString(string incomming)
        {
            string outgoing = string.Empty;

            for (int i = incomming.Length - 1; i >= 0; i--)
            {
                outgoing += incomming[i];
            }

            return outgoing;
        }
    }
}
