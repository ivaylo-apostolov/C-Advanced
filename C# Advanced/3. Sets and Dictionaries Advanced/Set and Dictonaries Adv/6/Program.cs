using System;
using System.Collections.Generic;
using System.Linq;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var tok = Console.ReadLine()
                    .Split(" -> ")
                    .ToArray();

                string color = tok[0];

                var tokens = tok[1]
                    .Split(",")
                    .ToArray();

                if (!dict.ContainsKey(color))
                {
                    dict[color] = new Dictionary<string, int>();
                }

                foreach (var item in tokens)
                {
                    if (!dict[color].ContainsKey(item))
                    {
                        dict[color][item] = 1;
                    }
                    else
                    {
                        dict[color][item]++;
                    }
                }                
            }

            var inputToFind = Console.ReadLine()
                    .Split();
            string colorToFind = inputToFind[0];
            string itemToFind = inputToFind[1];

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var kvp2 in kvp.Value)
                {
                    if (kvp.Key == colorToFind && kvp2.Key == itemToFind)
                    {
                        Console.WriteLine($"* {kvp2.Key} - {kvp2.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kvp2.Key} - {kvp2.Value}");
                    }
                }
            }
        }
    }
}
