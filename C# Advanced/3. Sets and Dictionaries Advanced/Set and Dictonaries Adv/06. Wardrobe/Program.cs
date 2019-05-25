using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ")
                    .ToArray();

                var colorOfClothes = input[0];
                var clothes = input[1]
                    .Split(",")
                    .ToArray();

                if (!dict.ContainsKey(colorOfClothes))
                {
                    dict[colorOfClothes] = new Dictionary<string, int>();
                }

                foreach (var clothe in clothes)
                {
                    if (!dict[colorOfClothes].ContainsKey(clothe))
                    {
                        dict[colorOfClothes][clothe] = 1;
                    }
                    else
                    {
                        dict[colorOfClothes][clothe]++;
                    }
                }
            }

            var searchedClothes = Console.ReadLine()
                .Split()
                .ToArray();

            var searchedColor = searchedClothes[0];
            var searchedClothe = searchedClothes[1];

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var kvp2 in kvp.Value)
                {
                    if (kvp.Key == searchedColor && kvp2.Key == searchedClothe)
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
