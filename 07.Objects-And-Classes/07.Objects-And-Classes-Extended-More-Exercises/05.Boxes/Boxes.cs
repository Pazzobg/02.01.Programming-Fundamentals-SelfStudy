namespace _05.Boxes
{
    using System;
    using System.Collections.Generic;

    public class Boxes
    {
        public static void Main()
        {
            var boxesList = new List<Box>();

            string[] input = Console.ReadLine().Split('|');

            while (input[0] != "end") 
            {
                int x1 = int.Parse(input[0].Trim().Split(':')[0]);
                int y1 = int.Parse(input[0].Trim().Split(':')[1]);

                int x2 = int.Parse(input[1].Trim().Split(':')[0]);
                int y2 = int.Parse(input[1].Trim().Split(':')[1]);

                int x3 = int.Parse(input[2].Trim().Split(':')[0]);
                int y3 = int.Parse(input[2].Trim().Split(':')[1]);

                int x4 = int.Parse(input[3].Trim().Split(':')[0]);
                int y4 = int.Parse(input[3].Trim().Split(':')[1]);

                var box = new Box
                {
                    UpperLeft = new Point
                    {
                        X = x1,
                        Y = y1
                    },
                    UpperRight = new Point
                    {
                        X = x2,
                        Y = y2
                    },
                    BottomLeft = new Point
                    {
                        X = x3, 
                        Y = y3
                    },
                    BottomRight = new Point
                    {
                        X = x4, 
                        Y = y4
                    }
                };

                boxesList.Add(box);

                input = Console.ReadLine().Split('|');
            }

            foreach (var box in boxesList)
            {
                double width = box.Width;
                double height = box.Height;

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {(width + height) * 2}");
                Console.WriteLine($"Area: {width * height}");
            }
        }
    }
}
