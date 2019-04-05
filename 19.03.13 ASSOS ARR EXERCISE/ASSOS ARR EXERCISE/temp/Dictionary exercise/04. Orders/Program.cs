using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<double>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                var tokens = input.Split().ToArray();

                string productName = tokens[0];
                double productPrice = double.Parse(tokens[1]);
                double productQuantity = double.Parse(tokens[2]);

                if (!dict.ContainsKey(productName))
                {
                    dict.Add(productName, new List<double>());
                    dict[productName].Add(productPrice);
                    dict[productName].Add(productQuantity);
                }
                else
                {
                    dict[productName][1] += productQuantity;

                    if (dict[productName][0] != productPrice)
                    {
                        dict[productName][0] = productPrice;
                    }
                }                
            }

            foreach (var kvp in dict)
            {
                double totalPrice = kvp.Value[0] * kvp.Value[1];
                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }
        }
    }
}
