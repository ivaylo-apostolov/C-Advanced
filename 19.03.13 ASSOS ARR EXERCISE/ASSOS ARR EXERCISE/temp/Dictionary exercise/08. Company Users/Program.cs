using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(" -> ").ToArray();

                string companyName = tokens[0];
                string employeeId = tokens[1];

                if (!dict.ContainsKey(companyName))
                {
                    dict[companyName] = new List<string>();
                }
                if (!dict[companyName].Contains(employeeId))
                {
                    dict[companyName].Add(employeeId);
                }
            }

            foreach (var kvp in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var value in kvp.Value)
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}
