using System;

namespace _10.CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliSeconds = seconds * 1000;
            long microSeconds = milliSeconds * 1000;
            decimal nanoseconds = (decimal)microSeconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliSeconds} milliseconds = {microSeconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
