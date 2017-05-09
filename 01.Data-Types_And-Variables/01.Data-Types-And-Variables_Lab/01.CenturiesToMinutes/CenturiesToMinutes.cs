using System;
using System.Threading.Tasks;

namespace _01.CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int inputCenturies = int.Parse(Console.ReadLine());

            int years = inputCenturies * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{inputCenturies} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
