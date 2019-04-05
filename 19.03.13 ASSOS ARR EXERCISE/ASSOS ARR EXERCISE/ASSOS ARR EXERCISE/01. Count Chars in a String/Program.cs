using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .ToArray();

            var dict = new Dictionary<char, int>();

            foreach (var item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (dict.ContainsKey(item[i]))
                    {
                        dict[item[i]]++;
                    }
                    else
                    {
                        dict.Add(item[i], 1);
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            
        }
    }
}
