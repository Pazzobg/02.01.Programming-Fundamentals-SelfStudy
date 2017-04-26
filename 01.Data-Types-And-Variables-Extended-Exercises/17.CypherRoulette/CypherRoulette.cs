using System;

namespace _17.CypherRoulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            string previousInput = string.Empty;
            string currentString = string.Empty;
            bool toTheBack = true;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                currentString = input;

                if (input == "spin")
                {
                    i--;
                    currentString = string.Empty;

                    if (toTheBack == true) toTheBack = false;
                    else toTheBack = true;
                }

                if (previousInput == input)
                {
                    result = string.Empty;
                    if (input == "spin")
                    {
                        if (toTheBack == true) toTheBack = false;
                        else toTheBack = true;
                    }
                    continue;
                }

                if (toTheBack == true)
                {
                    result = result + currentString;
                }
                else
                {
                    result = currentString + result;
                }
                previousInput = input;
            }
            Console.WriteLine(result);
        }
    }
}
