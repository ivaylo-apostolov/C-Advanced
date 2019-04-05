using System;
using System.Collections.Generic;

namespace _02._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split();

            var dict = new Dictionary<string, int>();

            foreach (var item in arr)
            {
                string value = item.ToLower();
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict[value] = 1;
                }
            }

            foreach (var item in dict)
            {
                if ((item.Value % 2) != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
            Console.WriteLine();
        }
    }
}
