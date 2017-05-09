using System;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            double trips = Math.Ceiling((persons / capacity));
            Console.WriteLine(trips);
        }
    }
}
