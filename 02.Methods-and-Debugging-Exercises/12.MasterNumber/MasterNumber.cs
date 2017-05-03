namespace _12.MasterNumber
{
    using System;

    public class MasterNumber
    {
        public static void Main()
        {
            int endNumber = int.Parse(Console.ReadLine());

            bool isPalindrome = false;
            bool isSumOfDigitsSeven = false;
            bool containsEvenDigit = false;

            for (int i = 1; i <= endNumber; i++)
            {
                isPalindrome = IsPalindrome(i);
                isSumOfDigitsSeven = IsSumOfDigitsSeven(i);
                containsEvenDigit = ContainsEvenDigit(i);

                if (isPalindrome && isSumOfDigitsSeven && containsEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(int num)
        {
            string inputToString = num.ToString();

            for (int i = 0; i < inputToString.Length / 2; i++)
            {
                if (inputToString[i] != inputToString[inputToString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsSumOfDigitsSeven(int num)
        {
            string input = num.ToString();
            int sum = 0;

            foreach (char c in input)       
            {
                sum += (byte)c;
            }

            // 48 is ascii value of zero
            // remove in one step rather than in the loop
            sum -= 48 * input.Length;

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ContainsEvenDigit(int num)
        {
            int remainder = 0;

            while (num > 0)
            {
                remainder = num % 10;

                if (remainder % 2 == 0)
                {
                    return true;
                }

                num /= 10;
            }

            return false;
        }
    }
}
