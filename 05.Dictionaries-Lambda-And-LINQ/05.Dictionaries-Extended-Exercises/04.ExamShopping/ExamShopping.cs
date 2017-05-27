namespace _04.ExamShopping
{
    using System;
    using System.Collections.Generic;

    public class ExamShopping
    {
        public static void Main()
        {
            var productStock = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "shopping")              // Stockpiling products
            {
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                if (!productStock.ContainsKey(itemName))
                {
                    productStock.Add(itemName, 0);
                }

                productStock[itemName] += itemQuantity;

                input = Console.ReadLine().Split();
            }

            input = Console.ReadLine().Split();

            while (input[0] != "exam")                  // Selling products
            {
                string wantedProduct = input[1];
                int wantedQuantity = int.Parse(input[2]);

                if (productStock.ContainsKey(wantedProduct))
                {
                    if (productStock[wantedProduct] <= 0)
                    {
                        Console.WriteLine($"{wantedProduct} out of stock");
                    }
                    else
                    {
                        productStock[wantedProduct] -= wantedQuantity;
                    }
                }
                else
                {
                    Console.WriteLine($"{wantedProduct} doesn't exist");
                }

                input = Console.ReadLine().Split();
            }

            foreach (var kvp in productStock)           // Final Stockreport
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
