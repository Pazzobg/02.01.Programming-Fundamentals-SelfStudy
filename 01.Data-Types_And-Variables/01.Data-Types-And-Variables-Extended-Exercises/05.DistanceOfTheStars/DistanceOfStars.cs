using System;

namespace _05.DistanceOfTheStars
{
    class DistanceOfStars
    {
        static void Main(string[] args)
        {
            decimal lightYear = 9450000000000u;
            decimal centauri = 4.22m * lightYear;
            decimal centerGalaxy = 26000 * lightYear;
            decimal diameterMilkyWay = 100000 * lightYear;
            decimal edgeUniverse = 46500000000 * lightYear;
            Console.WriteLine($"{centauri:e2}");      //dist to Proxima Centauri
            Console.WriteLine($"{centerGalaxy:e2}");     //dist to center of our galaxy
            Console.WriteLine($"{diameterMilkyWay:e2}");    //diameter of Milky Way
            Console.WriteLine($"{edgeUniverse:e2}"); //dist from Earth to the edge of the observable universe
        }
    }
}
