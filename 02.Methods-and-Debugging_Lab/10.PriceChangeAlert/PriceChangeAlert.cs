namespace _10.PriceChangeAlert
{
    using System;

    public class PriceChangeAlert
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double significanceLimit = (double.Parse(Console.ReadLine()) * 100);
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double deviation = PercentageCalculation(lastPrice, currentPrice);
                bool significantDifference = SignificantChange(deviation, significanceLimit);

                string message = GetResult(currentPrice, lastPrice, deviation, significantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string GetResult(double currentPrice, double lastPrice, double difference, bool significantChange)
        {
            string result = string.Empty;
            if (difference == 0)
            {
                result = string.Format($"NO CHANGE: {currentPrice}");
            }
            else if (!significantChange)
            {
                result = string.Format($"MINOR CHANGE: {lastPrice} to {currentPrice} ({difference:f2}%)");
            }
            else if (significantChange && (difference > 0))
            {
                result = string.Format($"PRICE UP: {lastPrice} to {currentPrice} ({difference:f2}%)");
            }
            else if (significantChange && (difference < 0))
            {
                result = string.Format($"PRICE DOWN: {lastPrice} to {currentPrice} ({difference:f2}%)");
            }

            return result;
        }

        private static bool SignificantChange(double deviation, double significanceLimit)
        {
            if (Math.Abs(deviation) >= significanceLimit)
            {
                return true;
            }

            return false;
        }

        private static double PercentageCalculation(double lastPrice, double currentPrice)
        {
            double percentageDifference = ((currentPrice - lastPrice) / lastPrice) * 100;
            return percentageDifference;
        }
    }
}
