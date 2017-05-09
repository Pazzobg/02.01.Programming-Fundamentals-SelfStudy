using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Triangle is valid.");
                if (a == b && b == c && c == a)
                {
                    Console.WriteLine("Triangle has no right angles");
                }
                else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}