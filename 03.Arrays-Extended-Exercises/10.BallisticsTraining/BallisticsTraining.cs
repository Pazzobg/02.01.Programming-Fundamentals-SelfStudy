namespace _10.BallisticsTraining
{
    using System;
    using System.Linq;

    public class BallisticsTraining
    {
        public static void Main()
        {
            int[] targetCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] cannonAdjustments = Console.ReadLine().Split(' ').ToArray();
            int cannonX = 0;
            int cannonY = 0;
            bool onTarget = true;

            for (int i = 0; i < cannonAdjustments.Length; i++)
            {
                if (i % 2 == 0 && cannonAdjustments[i] == "up")
                {
                    cannonY += int.Parse(cannonAdjustments[i + 1]);
                }
                else if (i % 2 == 0 && cannonAdjustments[i] == "down")
                {
                    cannonY -= int.Parse(cannonAdjustments[i + 1]);
                }
                else if (i % 2 == 0 && cannonAdjustments[i] == "left")
                {
                    cannonX -= int.Parse(cannonAdjustments[i + 1]);
                }
                else if (i % 2 == 0 && cannonAdjustments[i] == "right")
                {
                    cannonX += int.Parse(cannonAdjustments[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{cannonX}, {cannonY}]");

            int[] cannonTarget = { cannonX, cannonY };

            for (int i = 0; i < targetCoordinates.Length; i++)
            {
                if (cannonTarget[i] != targetCoordinates[i])
                {
                    onTarget = false;
                }
            }

            if (!onTarget)
            {
                Console.WriteLine("better luck next time...");
            }
            else
            {
                Console.WriteLine("got 'em!");
            }
        }
    }
}