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

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "buy")
            {
                var arr = command.Split().ToArray();

                string product = arr[0];
                double price = double.Parse(arr[1]);
                double quantities = double.Parse(arr[2]);

                if (!dict.ContainsKey(product))
                {
                    dict.Add(product, new List<double>());
                    dict[product].Add(price);
                    dict[product].Add(quantities);
                }
                else
                {
                    dict[product][1] += quantities;

                    if (dict[product][0] != price)
                    {
                        dict[product][0] = price;
                    }
                }
            }

            foreach (var item in dict)
            {
                double prices = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {prices:f2}");
            }
        }
    }
}
