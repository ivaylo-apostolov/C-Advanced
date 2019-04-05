using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "stop")
            {
                string mineralType = input;
                int quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(mineralType))
                {
                    dict[mineralType] = quantity;
                }
                else
                {
                    dict[mineralType] += quantity;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
