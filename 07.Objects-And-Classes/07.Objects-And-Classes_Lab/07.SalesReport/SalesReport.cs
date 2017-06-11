namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var totalSalesByTown = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                Sale currentSale = new Sale()
                {
                    Town = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = decimal.Parse(input[3])
                };

                if (!totalSalesByTown.ContainsKey(currentSale.Town))
                {
                    totalSalesByTown[currentSale.Town] = 0;
                }

                totalSalesByTown[currentSale.Town] += currentSale.Quantity * currentSale.Price; 
            }

            foreach (var kvp in totalSalesByTown.OrderBy(x => x.Key))
            {
                string townName = kvp.Key;
                decimal totalSales = kvp.Value;

                Console.WriteLine($"{townName} -> {totalSales:f2}");
            }
        }
    }
}
