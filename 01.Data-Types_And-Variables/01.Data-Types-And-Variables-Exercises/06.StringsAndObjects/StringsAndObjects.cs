using System;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";

            object concatenated = firstWord + " " + secondWord;
            string result = (string)concatenated;
            Console.WriteLine(result);
        }
    }
}
