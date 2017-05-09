using System;

namespace _06.IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool overflow = false; ;
            int counter = 0;
            byte number = 0; ;

            for (int i = 1; i <= n; i++)
            {
                number++;
                if (number == 0)
                {
                    counter++;
                    overflow = true;
                }
            }
            Console.WriteLine(number);
            if (overflow) 
            {
                Console.WriteLine($"Overflowed {counter} times");
            }
        }
    }
}
