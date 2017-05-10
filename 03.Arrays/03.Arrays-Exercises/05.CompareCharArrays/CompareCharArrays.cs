namespace _05.CompareCharArrays
{
    using System;

    public class CompareCharArrays
    {
        public static void Main()
        {
            string inOne = Console.ReadLine();
            string[] inputOne = inOne.Split(' ');
            char[] charArrayOne = new char[inputOne.Length];
            for (int i = 0; i < charArrayOne.Length; i++)
            {
                charArrayOne[i] = char.Parse(inputOne[i]);
            }

            string inTwo = Console.ReadLine();
            string[] inputTwo = inTwo.Split(' ');
            char[] charArrayTwo = new char[inputTwo.Length];
            for (int i = 0; i < charArrayTwo.Length; i++)
            {
                charArrayTwo[i] = char.Parse(inputTwo[i]);
            }

            bool first = false;
            bool second = false;
            int shorterArrLength = Math.Min(charArrayOne.Length, charArrayTwo.Length);

            for (int i = 0; i < shorterArrLength; i++)
            {
                if (charArrayOne[i] < charArrayTwo[i])
                {
                    first = true;
                    break;
                }
                else if (charArrayOne[i] > charArrayTwo[i])
                {
                    second = true;
                    break;
                }
                else
                {
                    continue;
                }
            }

            if (first)
            {
                Console.WriteLine(string.Join(string.Empty, charArrayOne));
                Console.WriteLine(string.Join(string.Empty, charArrayTwo));
            }
            else if(second)
            {
                Console.WriteLine(string.Join(string.Empty, charArrayTwo));
                Console.WriteLine(string.Join(string.Empty, charArrayOne));
            }
            else
            {
                if (charArrayOne.Length<charArrayTwo.Length)
                {
                    Console.WriteLine(string.Join(string.Empty, charArrayOne));
                    Console.WriteLine(string.Join(string.Empty, charArrayTwo));
                }
                else
                {
                    Console.WriteLine(string.Join(string.Empty, charArrayTwo));
                    Console.WriteLine(string.Join(string.Empty, charArrayOne));
                }
            }
        }
    }
}
