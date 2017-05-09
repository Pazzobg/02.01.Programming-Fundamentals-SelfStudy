using System;

namespace _08.TravellingAtLightspeed
{
    class TravellingAtLightspeed
    {
        static void Main(string[] args)
        {
            decimal lightYear = decimal.Parse(Console.ReadLine());

            decimal totalSeconds = (lightYear * (9450000000000)) / 300000;

            long seconds = (long)totalSeconds % 60;
            totalSeconds /= 60;
            long minutes = (long)totalSeconds % 60;
            totalSeconds /= 60;
            long hours = (long)totalSeconds % 24;
            totalSeconds /= 24;
            long days = (long)totalSeconds % 7;
            totalSeconds /= 7;
            long weeks = (long)totalSeconds;

            Console.WriteLine($"{weeks:f0} weeks\n{days:f0} days\n{hours:f0} hours\n{minutes:f0} minutes\n{seconds:f0} seconds");

            TimeSpan totalsecs = new TimeSpan((long)totalSeconds);
            Console.WriteLine($"{totalsecs:dd\\:hh\\:mm\\:ss}");
        }
    }
}
