namespace _03.EnglishNameOfTheLastDigit
{
    using System;

    public class LastDigitName
    {
        public static void Main()
        {
            long input = long.Parse(Console.ReadLine());

            long lastDigit = GetLastDigit(input);
            string result = ConvertDigitToText(lastDigit);

            Console.WriteLine(result);
        }

        public static string ConvertDigitToText(long lastDigit)
        {
            string result = string.Empty;

            switch (lastDigit)
            {
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
                case 0: result = "zero"; break;
            }

            return result;
        }

        public static long GetLastDigit(long n)
        {
            return Math.Abs(n % 10);
        }
    }
}
