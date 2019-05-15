using System;
using System.Collections.Generic;

namespace Dictionary_and_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfNames = int.Parse(Console.ReadLine());

            var set = new HashSet<string>();

            for (int i = 0; i < numberOfNames; i++)
            {
                var name = Console.ReadLine();

                set.Add(name);
            }

            Console.WriteLine();

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
