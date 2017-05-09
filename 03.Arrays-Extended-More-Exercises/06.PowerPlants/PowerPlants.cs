namespace _06.PowerPlants
{
    using System;
    using System.Linq;

    public class PowerPlants
    {
        public static void Main()
        {
            int[] plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int days = 1;
            int seasons = 0;
            int alive = plants.Sum();
            int loopEnd = plants.Length;
            bool alivePlant = false;

            while (alive > 0)
            {
                for (int i = 0; i < loopEnd; i++) // each itereation repr a day
                {
                    alivePlant = false;

                    for (int j = 0; j < loopEnd; j++) // iterates plants during the day
                    {
                        if (i == j && plants[j] > 0)
                        {
                            plants[j]++;
                        }

                        if (plants[j] > 0) // withering of each plant
                        {
                            plants[j]--;
                        }
                    }

                    for (int m = 0; m < loopEnd; m++) // check if any plant still alive
                    {
                        if (plants[m] > 0)
                        {
                            alivePlant = true;
                            break;
                        }
                    }

                    if (alivePlant == false)
                    {
                        break;
                    }

                    days++;
                }

                for (int k = 0; k < loopEnd; k++) // checks and adds +1 power to all alive plants at the end of a season
                {
                    if (plants[k] > 0)
                    {
                        plants[k]++;
                    }
                }

                if (alivePlant == false)
                {
                    break;
                }

                seasons++;
                alive = plants.Sum();
            }

            Console.WriteLine($"survived {days} days ({seasons} seasons)");
        }
    }
}
