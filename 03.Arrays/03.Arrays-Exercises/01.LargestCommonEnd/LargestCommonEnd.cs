namespace _01.LargestCommonEnd
{
    using System;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] inputArrOne = Console.ReadLine().Split(' ');
            string[] inputArrTwo = Console.ReadLine().Split(' ');

            int counterFront = 0;
            int counterAft = 0;

            int loopEnd = Math.Min(inputArrOne.Length, inputArrTwo.Length);


            for (int frontCheck = 0; frontCheck < loopEnd; frontCheck++)
            {
                if (inputArrOne[frontCheck] == inputArrTwo[frontCheck])
                {
                    counterFront++;
                }
                else
                {
                    break;
                }
            }

            for (int i = inputArrOne.Length - 1, j = inputArrTwo.Length - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (inputArrOne[i] == inputArrTwo[j])
                {
                    counterAft++;
                }
                else
                {
                    break;
                }
            }

            //Array.Reverse(inputArrOne);
            //Array.Reverse(inputArrTwo);

            //for (int aftCheck = 0; aftCheck < loopEnd; aftCheck++)
            //{
            //    if (inputArrOne[aftCheck] == inputArrTwo[aftCheck])
            //    {
            //        counterAft++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}


            Console.WriteLine(Math.Max(counterFront, counterAft));
        }
    }
}
