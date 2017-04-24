using System;

namespace _05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            //Required solution: 

            bool value = Convert.ToBoolean(Console.ReadLine());

            if (value == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            //More "basic" solution, still works though:
            //string input = Console.ReadLine();
            //bool check = false;

            //if (input == "True")
            //{
            //    check = true;
            //}
            //else
            //{
            //    check = false;
            //}

            //if (check == true)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
        }
    }
}
