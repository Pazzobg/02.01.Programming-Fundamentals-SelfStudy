namespace _06.Batteries
{
    using System;
    using System.Collections.Generic;

    public class Batteries
    {
        public static void Main()
        {
            string[] batteries = Console.ReadLine().Split(' ');
            var batteryCapacities = new List<double>();
            for (int i = 0; i < batteries.Length; i++)
            {
                batteryCapacities.Add(double.Parse(batteries[i]));
            }

            double[] capacity = new double[batteryCapacities.Count];
            batteryCapacities.CopyTo(capacity);

            string[] usage = Console.ReadLine().Split(' ');
            var usagePerHour = new List<double>();
            for (int i = 0; i < usage.Length; i++)
            {
                usagePerHour.Add(double.Parse(usage[i]));
            }

            int[] hoursArray = new int[batteryCapacities.Count];

            int testHours = int.Parse(Console.ReadLine());

            for (int stressTest = 0; stressTest < testHours; stressTest++)
            {
                for (int j = 0; j < batteryCapacities.Count; j++)
                {
                    if (batteryCapacities[j] > 0)
                    {
                        batteryCapacities[j] -= usagePerHour[j];
                        hoursArray[j]++;
                    }
                }
            }

            for (int i = 0; i < batteryCapacities.Count; i++)
            {
                if (batteryCapacities[i] > 0)
                {
                    double percentageLeft = (batteryCapacities[i] / capacity[i]) * 100;
                    Console.WriteLine($"Battery {i + 1}: {batteryCapacities[i]:f2} mAh ({percentageLeft:f2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {hoursArray[i]} hours)");
                }
            }
        }
    }
}
