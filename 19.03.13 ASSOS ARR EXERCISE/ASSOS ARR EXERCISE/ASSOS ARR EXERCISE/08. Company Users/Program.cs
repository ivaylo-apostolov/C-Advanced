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
                var arr = input.Split(" -> ").ToArray();

                string company = arr[0];
                string employeeId = arr[1];

                if (!dict.ContainsKey(company))
                {
                    dict[company] = new List<string>();
                }
                if (!dict[company].Contains(employeeId))
                {
                    dict[company].Add(employeeId);
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
