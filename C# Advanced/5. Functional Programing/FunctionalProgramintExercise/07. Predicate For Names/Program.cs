﻿using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split()
                .Where(x => x.Length <= n)
                .ToArray();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
