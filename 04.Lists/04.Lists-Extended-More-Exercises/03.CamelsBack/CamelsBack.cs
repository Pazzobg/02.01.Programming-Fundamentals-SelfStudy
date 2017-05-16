namespace _03.CamelsBack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CamelsBack
    {
        public static void Main()
        {
            var buildingsList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelsBack = int.Parse(Console.ReadLine());
            int roundsCounter = 0;
            int cycleLength = (buildingsList.Count - camelsBack) / 2;

            for (int i = 0; i < cycleLength; i++)
            {
                buildingsList.RemoveAt(0);
                buildingsList.RemoveAt(buildingsList.Count - 1);

                roundsCounter++;
            }

            if (roundsCounter > 0)
            {
                Console.WriteLine($"{roundsCounter} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildingsList)}");
            }
            else
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildingsList)}");
            }
        }
    }
}
