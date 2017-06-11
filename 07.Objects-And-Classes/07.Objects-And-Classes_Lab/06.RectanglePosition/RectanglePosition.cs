namespace _06.RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main()
        {
            double[] rectangleOneData = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] rectangleTwoData = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Rectangle firstRect = new Rectangle
            {
                Left = rectangleOneData[0],
                Top = rectangleOneData[1],
                Width = rectangleOneData[2],
                Height = rectangleOneData[3]
            };

            Rectangle secondRect = new Rectangle
            {
                Left = rectangleTwoData[0],
                Top = rectangleTwoData[1],
                Width = rectangleTwoData[2],
                Height = rectangleTwoData[3]
            };

            bool isInside = CheckIfFirstInsideSecond(firstRect, secondRect);

            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static bool CheckIfFirstInsideSecond(Rectangle firstRect, Rectangle secondRect)
        {

            bool isInsideFromLeft = firstRect.Left >= secondRect.Left ? true : false;
            bool isInsideFromRight = firstRect.Right <= secondRect.Right ? true : false;
            bool isInsideFromBottom = firstRect.Bottom >= secondRect.Bottom ? true : false;
            bool isInsideFromTop = firstRect.Top <= secondRect.Top ? true : false;

            return isInsideFromLeft && isInsideFromRight && isInsideFromTop && isInsideFromBottom ? true : false;
        }
    }
}
