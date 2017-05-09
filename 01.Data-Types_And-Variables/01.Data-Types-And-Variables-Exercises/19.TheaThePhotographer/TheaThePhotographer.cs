using System;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long totalPhotos = long.Parse(Console.ReadLine());
            long filterTimeSecs = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTimeSecs = long.Parse(Console.ReadLine());

            long totalFilterTime = filterTimeSecs * totalPhotos;
            long totalPhotosForUpload = (long)Math.Ceiling((totalPhotos * filterFactor) / 100.0);
            long totalUploadTime = totalPhotosForUpload * uploadTimeSecs;
            long totalTime = totalFilterTime + totalUploadTime;

            long totalSeconds = totalTime % 60;
            totalTime /= 60;
            long totalMinutes = totalTime % 60;
            totalTime /= 60;
            long totalHours = totalTime % 24;
            totalTime /= 24;
            long totalDays = totalTime;

            Console.WriteLine($"{totalDays}:{totalHours:00}:{totalMinutes:00}:{totalSeconds:00}");


            //Alternative way of calculating time: 
            //long totalDays = totalTime / 86400;
            //long totalHours = (totalTime % 86400) / 3600;
            //long totalMinutes = ((totalTime % 86400) % 3600) / 60;
            //long totalSeconds = ((totalTime % 86400) % 3600) % 60;


            //Alternative solution, using TimeSpan: 
            //var output = TimeSpan.FromSeconds(double.Parse(totalTime.ToString()));
            //var result = output.ToString("d':'hh':'mm':'ss");

            //Console.WriteLine(result);
        }
    }
}
