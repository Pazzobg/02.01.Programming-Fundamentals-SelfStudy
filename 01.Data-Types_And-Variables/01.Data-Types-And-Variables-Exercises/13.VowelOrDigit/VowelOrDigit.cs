using System;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char input = Convert.ToChar(Console.ReadLine());

            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("vowel");
            }
            //else if (input == '0' || input == '1' || input == '2' || input == '3' || input == '4' || input == '5' || input == '6' || input == '7' || input == '8' || input == '9')
            else if (char.IsNumber(input))          //solution found in SoftUni forum
            //else if (input >= 48 && input <= 57)  //solution found in SoftUni forum
            {
                Console.WriteLine("digit");
            }
            else
                Console.WriteLine("other");
        }
    }
}
