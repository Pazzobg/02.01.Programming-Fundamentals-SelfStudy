namespace _04.TripleSum
{
    using System;

    public class TripleSum
    {
        public static void Main()
        {
            string inputs = Console.ReadLine();
            string[] items = inputs.Split(' ');
            var arr = new int[items.Length];
            bool mark = false;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if ((j > i) && (arr[k] == arr[i] + arr[j]))
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[k]}");
                            mark = true;
                            break;
                        }
                    }
                }
            }

            if (!mark)
            {
                Console.WriteLine("No");
            }
        }
    }
}
