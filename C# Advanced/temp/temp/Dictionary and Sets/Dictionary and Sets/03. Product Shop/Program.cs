using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ")
                .ToArray();

            var dict = new SortedDictionary<string, Dictionary<string, double>>();

            while (input[0] != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!dict.ContainsKey(shop))
                {
                    dict[shop] = new Dictionary<string, double>();
                }

                if (!dict[shop].ContainsKey(product))
                {
                    dict[shop][product] = price;
                }

                input = Console.ReadLine()
                .Split(", ")
                .ToArray();
            }

            foreach (var shop in dict)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
