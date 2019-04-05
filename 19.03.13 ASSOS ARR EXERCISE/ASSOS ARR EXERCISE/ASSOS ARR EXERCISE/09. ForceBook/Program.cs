using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                var arr = input.Split().ToArray();

                if (arr[0] == "Lighter" || arr[0] == "Darker" || arr[0] == "Light" || arr[0] == "Dark")
                {
                    arr = input.Split(" | ").ToArray();
                }
                else
                {
                    arr = input.Split(" -> ").ToArray();
                }

                string index0 = arr[0];
                string index1 = arr[1];

                if (index0 == "Lighter" || index0 == "Darker" || index0 == "Light" || index0 == "Dark")
                {
                    if (!dict.ContainsKey(index0))
                    {
                        dict[index0] = new List<string>();
                    }

                    dict[index0].Add(index1);
                }
                else
                {
                    if (index1 == "Lighter" || index1 == "Light")
                    {
                        string dark = string.Empty;
                        if (index1 == "Lighter")
                        {
                            dark = "Darker";
                        }
                        else if (index1 == "Light")
                        {
                            dark = "Dark";
                        }

                        if (dict.ContainsKey(dark) && dict[dark].Contains(index0))
                        {
                            dict[dark].Remove(index0);
                        }
                        if (!dict.ContainsKey(index1))
                        {
                            dict[index1] = new List<string>();
                        }
                        dict[index1].Add(index0);
                        Console.WriteLine($"{index0} joins the {index1} side!");
                    }
                    if (index1 == "Darker" || index1 == "Dark")
                    {
                        string light = string.Empty;
                        if (index1 == "Darker")
                        {
                            light = "Lighter";
                        }
                        else if (index1 == "Dark")
                        {
                            light = "Light";
                        }

                        if (dict.ContainsKey(light) && dict[light].Contains(index0))
                        {
                            dict[light].Remove(index0);
                        }
                        if (!dict.ContainsKey(index1))
                        {
                            dict[index1] = new List<string>();
                        }
                        dict[index1].Add(index0);
                        Console.WriteLine($"{index0} joins the {index1} side!");
                    }
                }
            }

            string empty = string.Empty;
            bool isEmpty = false;

            foreach (var kvp in dict)
            {
                if (kvp.Value.Count == 0)
                {
                    empty = kvp.Key;
                    isEmpty = true;
                }
            }

            if (isEmpty)
            {
                dict.Remove(empty);
            }

            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                foreach (var value in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {value}");
                }
            }
        }
    }
}
