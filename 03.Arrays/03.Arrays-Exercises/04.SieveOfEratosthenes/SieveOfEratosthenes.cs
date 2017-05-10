namespace _04.SieveOfEratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] numArray= new bool[n+1];        

            for (int i = 2; i <= n; i++)
            {
                numArray[i] = true;
            }

            for (int i = 2; i < numArray.Length; i++)
            {
                if (numArray[i] == true)
                {
                    for (int a = 2; (a * i) <= n; a++)
                    {
                        numArray[a * i] = false;
                    }

                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }
    }
}
