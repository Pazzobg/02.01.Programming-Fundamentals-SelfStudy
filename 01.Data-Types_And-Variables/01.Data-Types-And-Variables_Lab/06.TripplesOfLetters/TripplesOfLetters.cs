using System;

namespace _06.TripplesOfLetters
{
    class TripplesOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int limit = 'a' + n;

            for (char firstLetter = 'a'; firstLetter < limit; firstLetter++)
            {
                for (char secondLetter = 'a'; secondLetter < limit; secondLetter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter < limit; thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
