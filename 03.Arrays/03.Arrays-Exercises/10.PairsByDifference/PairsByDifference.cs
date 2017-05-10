namespace _10.PairsByDifference
{
    using System;
    using System.Linq;

    public class PairsByDifference
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j < input.Length; j++) // Nqma smisyl j da zapochva ot 0, taka propuskame 
                {                                      // sravnenieto na edin element sys samiq sebe si. 
                    if (input[j] - input[i] == difference) // ako j=0 pak raboti though.
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
