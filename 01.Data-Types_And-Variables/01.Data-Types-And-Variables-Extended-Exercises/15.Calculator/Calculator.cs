using System;

namespace _15.Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int firstOperand = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            int secondOperand = int.Parse(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+': result = firstOperand + secondOperand;break;
                case '-': result = firstOperand - secondOperand;break;
                case '*':result = firstOperand * secondOperand;break;
                case '/': result = firstOperand / secondOperand;break;
            }
            Console.WriteLine($"{firstOperand} {op} {secondOperand} = {result}");
        }
    }
}
