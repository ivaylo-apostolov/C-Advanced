using System;
using System.Collections.Generic;

namespace _05._Count_Symbols1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dict = new SortedDictionary<char, int>();

            foreach (var ch in input)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict[ch] = 1;
                }
                else
                {
                    dict[ch]++;
                }
                
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
