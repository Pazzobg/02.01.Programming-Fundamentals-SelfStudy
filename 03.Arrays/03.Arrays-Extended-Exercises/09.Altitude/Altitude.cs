namespace _09.Altitude
{
    using System;

    public class Altitude
    {
        public static void Main()
        {
            string[] inputArr = Console.ReadLine().Split(' ');

            long subStringLength = (inputArr.Length - 1) / 2;
            string[] commands = new string[subStringLength];
            long[] altChanges = new long[subStringLength];

            long altitude = long.Parse(inputArr[0]);
            long j = 0;
            long k = 0;
            bool safe = true;

            for (long i = 0; i < inputArr.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else if (i % 2 != 0)
                {
                    commands[j] = inputArr[i];
                    j++;
                }
                else
                {
                    altChanges[k] = long.Parse(inputArr[i]);
                    k++;
                }
            }

            for (long i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "up": altitude += altChanges[i]; break;
                    case "down": altitude -= altChanges[i]; break;
                }

                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    safe = false;
                    break;
                }
            }

            if (safe)
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
        }
    }
}
