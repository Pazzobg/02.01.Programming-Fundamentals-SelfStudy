using System;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float timeInSeconds = (hours * 3600) + (minutes * 60) + seconds;
            float timeInHours = hours + (minutes / 60) + (seconds / 3600);
            float distanceInKm = distanceMeters / 1000;
            float distanceInMi = distanceMeters / 1609;

            Console.WriteLine(distanceMeters / timeInSeconds);
            Console.WriteLine(distanceInKm / timeInHours);
            Console.WriteLine(distanceInMi / timeInHours);
        }
    }
}
