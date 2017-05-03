namespace _10.CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine().ToLower();

            if (property == "face")
            {
                Console.WriteLine(CalculateFaceDiagonal(side));
            }
            else if (property == "space")
            {
                Console.WriteLine(CalculateSpaceDiagonal(side));
            }
            else if (property == "volume")
            {
                Console.WriteLine(CalculateVolume(side));
            }
            else if (property == "area")
            {
                Console.WriteLine(CalculateSurfaceArea(side));
            }
        }

        public static string CalculateFaceDiagonal(double s)
        {
            double faceDiag = Math.Sqrt(2 * Math.Pow(s, 2));
            return $"{faceDiag:f2}";
        }

        public static string CalculateSpaceDiagonal(double s)
        {
            double spacediag = Math.Sqrt(3 * Math.Pow(s, 2));
            return $"{spacediag:f2}";
        }

        public static string CalculateVolume(double s)
        {
            double volume = Math.Pow(s, 3);
            return $"{volume:f2}";
        }

        public static string CalculateSurfaceArea(double s)
        {
            double area = 6 * Math.Pow(s, 2);
            return $"{area:f2}";
        }
    }
}
