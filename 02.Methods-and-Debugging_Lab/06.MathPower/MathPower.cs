namespace _06.MathPower
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double calculatedResult = PowerOfNumber(number, power);

            Console.WriteLine(calculatedResult);
        }

        public static double PowerOfNumber(double num, double pow)
        {
            double result = 1;

            for (double i = 0; i < pow; i++)
            {
                result *= num;
            }

            //double result = Math.Pow(num, pow);

            return result;
        }
    }
}
